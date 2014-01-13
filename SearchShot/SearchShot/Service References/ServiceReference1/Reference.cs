﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.34003
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.Phone.ServiceReference, version 3.7.0.0
// 
namespace SearchShot.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.IAsyncResult BeginGetData(string value, System.AsyncCallback callback, object asyncState);
        
        string EndGetData(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService1/Inscription", ReplyAction="http://tempuri.org/IService1/InscriptionResponse")]
        System.IAsyncResult BeginInscription(string password, string login, string mail, System.AsyncCallback callback, object asyncState);
        
        int EndInscription(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService1/Authentification", ReplyAction="http://tempuri.org/IService1/AuthentificationResponse")]
        System.IAsyncResult BeginAuthentification(string login, string password, System.AsyncCallback callback, object asyncState);
        
        bool EndAuthentification(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : SearchShot.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InscriptionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public InscriptionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public int Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthentificationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public AuthentificationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public bool Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<SearchShot.ServiceReference1.IService1>, SearchShot.ServiceReference1.IService1 {
        
        private BeginOperationDelegate onBeginGetDataDelegate;
        
        private EndOperationDelegate onEndGetDataDelegate;
        
        private System.Threading.SendOrPostCallback onGetDataCompletedDelegate;
        
        private BeginOperationDelegate onBeginInscriptionDelegate;
        
        private EndOperationDelegate onEndInscriptionDelegate;
        
        private System.Threading.SendOrPostCallback onInscriptionCompletedDelegate;
        
        private BeginOperationDelegate onBeginAuthentificationDelegate;
        
        private EndOperationDelegate onEndAuthentificationDelegate;
        
        private System.Threading.SendOrPostCallback onAuthentificationCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<GetDataCompletedEventArgs> GetDataCompleted;
        
        public event System.EventHandler<InscriptionCompletedEventArgs> InscriptionCompleted;
        
        public event System.EventHandler<AuthentificationCompletedEventArgs> AuthentificationCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SearchShot.ServiceReference1.IService1.BeginGetData(string value, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetData(value, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string SearchShot.ServiceReference1.IService1.EndGetData(System.IAsyncResult result) {
            return base.Channel.EndGetData(result);
        }
        
        private System.IAsyncResult OnBeginGetData(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string value = ((string)(inValues[0]));
            return ((SearchShot.ServiceReference1.IService1)(this)).BeginGetData(value, callback, asyncState);
        }
        
        private object[] OnEndGetData(System.IAsyncResult result) {
            string retVal = ((SearchShot.ServiceReference1.IService1)(this)).EndGetData(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetDataCompleted(object state) {
            if ((this.GetDataCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetDataCompleted(this, new GetDataCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetDataAsync(string value) {
            this.GetDataAsync(value, null);
        }
        
        public void GetDataAsync(string value, object userState) {
            if ((this.onBeginGetDataDelegate == null)) {
                this.onBeginGetDataDelegate = new BeginOperationDelegate(this.OnBeginGetData);
            }
            if ((this.onEndGetDataDelegate == null)) {
                this.onEndGetDataDelegate = new EndOperationDelegate(this.OnEndGetData);
            }
            if ((this.onGetDataCompletedDelegate == null)) {
                this.onGetDataCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetDataCompleted);
            }
            base.InvokeAsync(this.onBeginGetDataDelegate, new object[] {
                        value}, this.onEndGetDataDelegate, this.onGetDataCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SearchShot.ServiceReference1.IService1.BeginInscription(string password, string login, string mail, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginInscription(password, login, mail, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        int SearchShot.ServiceReference1.IService1.EndInscription(System.IAsyncResult result) {
            return base.Channel.EndInscription(result);
        }
        
        private System.IAsyncResult OnBeginInscription(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string password = ((string)(inValues[0]));
            string login = ((string)(inValues[1]));
            string mail = ((string)(inValues[2]));
            return ((SearchShot.ServiceReference1.IService1)(this)).BeginInscription(password, login, mail, callback, asyncState);
        }
        
        private object[] OnEndInscription(System.IAsyncResult result) {
            int retVal = ((SearchShot.ServiceReference1.IService1)(this)).EndInscription(result);
            return new object[] {
                    retVal};
        }
        
        private void OnInscriptionCompleted(object state) {
            if ((this.InscriptionCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.InscriptionCompleted(this, new InscriptionCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void InscriptionAsync(string password, string login, string mail) {
            this.InscriptionAsync(password, login, mail, null);
        }
        
        public void InscriptionAsync(string password, string login, string mail, object userState) {
            if ((this.onBeginInscriptionDelegate == null)) {
                this.onBeginInscriptionDelegate = new BeginOperationDelegate(this.OnBeginInscription);
            }
            if ((this.onEndInscriptionDelegate == null)) {
                this.onEndInscriptionDelegate = new EndOperationDelegate(this.OnEndInscription);
            }
            if ((this.onInscriptionCompletedDelegate == null)) {
                this.onInscriptionCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnInscriptionCompleted);
            }
            base.InvokeAsync(this.onBeginInscriptionDelegate, new object[] {
                        password,
                        login,
                        mail}, this.onEndInscriptionDelegate, this.onInscriptionCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SearchShot.ServiceReference1.IService1.BeginAuthentification(string login, string password, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginAuthentification(login, password, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        bool SearchShot.ServiceReference1.IService1.EndAuthentification(System.IAsyncResult result) {
            return base.Channel.EndAuthentification(result);
        }
        
        private System.IAsyncResult OnBeginAuthentification(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string login = ((string)(inValues[0]));
            string password = ((string)(inValues[1]));
            return ((SearchShot.ServiceReference1.IService1)(this)).BeginAuthentification(login, password, callback, asyncState);
        }
        
        private object[] OnEndAuthentification(System.IAsyncResult result) {
            bool retVal = ((SearchShot.ServiceReference1.IService1)(this)).EndAuthentification(result);
            return new object[] {
                    retVal};
        }
        
        private void OnAuthentificationCompleted(object state) {
            if ((this.AuthentificationCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.AuthentificationCompleted(this, new AuthentificationCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void AuthentificationAsync(string login, string password) {
            this.AuthentificationAsync(login, password, null);
        }
        
        public void AuthentificationAsync(string login, string password, object userState) {
            if ((this.onBeginAuthentificationDelegate == null)) {
                this.onBeginAuthentificationDelegate = new BeginOperationDelegate(this.OnBeginAuthentification);
            }
            if ((this.onEndAuthentificationDelegate == null)) {
                this.onEndAuthentificationDelegate = new EndOperationDelegate(this.OnEndAuthentification);
            }
            if ((this.onAuthentificationCompletedDelegate == null)) {
                this.onAuthentificationCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnAuthentificationCompleted);
            }
            base.InvokeAsync(this.onBeginAuthentificationDelegate, new object[] {
                        login,
                        password}, this.onEndAuthentificationDelegate, this.onAuthentificationCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override SearchShot.ServiceReference1.IService1 CreateChannel() {
            return new Service1ClientChannel(this);
        }
        
        private class Service1ClientChannel : ChannelBase<SearchShot.ServiceReference1.IService1>, SearchShot.ServiceReference1.IService1 {
            
            public Service1ClientChannel(System.ServiceModel.ClientBase<SearchShot.ServiceReference1.IService1> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetData(string value, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = value;
                System.IAsyncResult _result = base.BeginInvoke("GetData", _args, callback, asyncState);
                return _result;
            }
            
            public string EndGetData(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("GetData", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginInscription(string password, string login, string mail, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[3];
                _args[0] = password;
                _args[1] = login;
                _args[2] = mail;
                System.IAsyncResult _result = base.BeginInvoke("Inscription", _args, callback, asyncState);
                return _result;
            }
            
            public int EndInscription(System.IAsyncResult result) {
                object[] _args = new object[0];
                int _result = ((int)(base.EndInvoke("Inscription", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginAuthentification(string login, string password, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[2];
                _args[0] = login;
                _args[1] = password;
                System.IAsyncResult _result = base.BeginInvoke("Authentification", _args, callback, asyncState);
                return _result;
            }
            
            public bool EndAuthentification(System.IAsyncResult result) {
                object[] _args = new object[0];
                bool _result = ((bool)(base.EndInvoke("Authentification", _args, result)));
                return _result;
            }
        }
    }
}
