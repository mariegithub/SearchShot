﻿using SearchShot.Controls;
using SearchShot.Models;
using Microsoft.Phone.Controls;
using Nokia.Graphics.Imaging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace SearchShot
{
    public partial class FilterPage : PhoneApplicationPage
    {
        #region Members

        private bool _busy;

        #endregion

        #region Properties

        private bool Busy
        {
            get
            {
                return _busy;
            }

            set
            {
                if (_busy != value)
                {
                    _busy = value;

                    ProgressBar.Visibility = _busy ? Visibility.Visible : Visibility.Collapsed;
                    ProgressBar.IsIndeterminate = _busy;
                }
            }
        }

        #endregion

        public FilterPage()
        {
            InitializeComponent();

            ApplyOrientation(Orientation);

            Loaded += FilterPage_Loaded;
        }

        #region Protected methods

        protected override void OnOrientationChanged(OrientationChangedEventArgs e)
        {
            base.OnOrientationChanged(e);

            ApplyOrientation(e.Orientation);
        }

        #endregion

        #region Private methods

        private async void FilterPage_Loaded(object sender, RoutedEventArgs e)
        {
            await RenderAsync();
        }

        /// <summary>
        /// Asynchronously renders filter image thumbnails.
        /// </summary>
        private async Task RenderAsync()
        {
            if (!Busy)
            {
                Busy = true;

                int side = 136;

                try
                {
                    using (Bitmap bitmap = await App.PhotoModel.RenderThumbnailBitmapAsync(side))
                    {
                        await RenderThumbnailsAsync(bitmap, side, App.FilterModel.ArtisticFilters, StandardFiltersWrapPanel);
                        await RenderThumbnailsAsync(bitmap, side, App.FilterModel.ColorFilters, ColorFiltersWrapPanel);
                        await RenderThumbnailsAsync(bitmap, side, App.FilterModel.MoveFilters, MoveFiltersWrapPanel);
                        await RenderThumbnailsAsync(bitmap, side, App.FilterModel.EnhancementFilters, EnhancementFiltersWrapPanel);
                    }
                }
                catch (Exception)
                {
                    NavigationService.GoBack();
                }

                Busy = false;
            }
        }

        /// <summary>
        /// For the given bitmap renders filtered thumbnails for each filter in given list and populates
        /// the given wrap panel with the them.
        /// 
        /// For quick rendering, renders 10 thumbnails synchronously and then releases the calling thread.
        /// </summary>
        /// <param name="bitmap">Source bitmap to be filtered</param>
        /// <param name="side">Side length of square thumbnails to be generated</param>
        /// <param name="list">List of filters to be used, one per each thumbnail to be generated</param>
        /// <param name="panel">Wrap panel to be populated with the generated thumbnails</param>
        private async Task RenderThumbnailsAsync(Bitmap bitmap, int side, List<FilterModel> list, WrapPanel panel)
        {
            using (BitmapImageSource source = new BitmapImageSource(bitmap))
            using (FilterEffect effect = new FilterEffect(source))
            {
                foreach (FilterModel filter in list)
                {
                    effect.Filters = filter.Components;

                    WriteableBitmap writeableBitmap = new WriteableBitmap(side, side);

                    using (WriteableBitmapRenderer renderer = new WriteableBitmapRenderer(effect, writeableBitmap))
                    {
                        await renderer.RenderAsync();

                        writeableBitmap.Invalidate();

                        PhotoThumbnail photoThumbnail = new PhotoThumbnail()
                        {
                            Bitmap = writeableBitmap,
                            Text = filter.Name,
                            Width = side,
                            Margin = new Thickness(6)
                        };

                        photoThumbnail.Tap += (object sender, System.Windows.Input.GestureEventArgs e) =>
                        {
                            App.PhotoModel.ApplyFilter(filter);
                            App.PhotoModel.Dirty = true;

                            NavigationService.GoBack();
                        };

                        panel.Children.Add(photoThumbnail);
                    }
                }
            }
        }

        /// <summary>
        /// Apply orientation specific layout.
        /// </summary>
        /// <param name="orientation">Page orientation</param>
        private void ApplyOrientation(PageOrientation orientation)
        {
            if (orientation.HasFlag(PageOrientation.Portrait))
            {
                Pivot.Margin = new Thickness(0);
            }
            else
            {
                Pivot.Margin = new Thickness(0, -16, 0, 0);
            }
        }

        #endregion
    }
}