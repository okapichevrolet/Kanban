﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.17929.
// 
#pragma warning disable 1591

namespace Kanban_board_project.CheckingEmailAddress {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="EmailVerifySoap", Namespace="http://ws.cdyne.com/")]
    public partial class EmailVerify : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback VerifyMXRecordOperationCompleted;
        
        private System.Threading.SendOrPostCallback VerifyEmailOperationCompleted;
        
        private System.Threading.SendOrPostCallback VerifyEmailWithTimeoutOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public EmailVerify() {
            this.Url = global::Kanban_board_project.Properties.Settings.Default.Kanban_board_project_CheckingEmailAddress_EmailVerify;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event VerifyMXRecordCompletedEventHandler VerifyMXRecordCompleted;
        
        /// <remarks/>
        public event VerifyEmailCompletedEventHandler VerifyEmailCompleted;
        
        /// <remarks/>
        public event VerifyEmailWithTimeoutCompletedEventHandler VerifyEmailWithTimeoutCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ws.cdyne.com/VerifyMXRecord", RequestNamespace="http://ws.cdyne.com/", ResponseNamespace="http://ws.cdyne.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int VerifyMXRecord(string email, string LicenseKey) {
            object[] results = this.Invoke("VerifyMXRecord", new object[] {
                        email,
                        LicenseKey});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void VerifyMXRecordAsync(string email, string LicenseKey) {
            this.VerifyMXRecordAsync(email, LicenseKey, null);
        }
        
        /// <remarks/>
        public void VerifyMXRecordAsync(string email, string LicenseKey, object userState) {
            if ((this.VerifyMXRecordOperationCompleted == null)) {
                this.VerifyMXRecordOperationCompleted = new System.Threading.SendOrPostCallback(this.OnVerifyMXRecordOperationCompleted);
            }
            this.InvokeAsync("VerifyMXRecord", new object[] {
                        email,
                        LicenseKey}, this.VerifyMXRecordOperationCompleted, userState);
        }
        
        private void OnVerifyMXRecordOperationCompleted(object arg) {
            if ((this.VerifyMXRecordCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.VerifyMXRecordCompleted(this, new VerifyMXRecordCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ws.cdyne.com/VerifyEmail", RequestNamespace="http://ws.cdyne.com/", ResponseNamespace="http://ws.cdyne.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ReturnValues VerifyEmail(string email, string LicenseKey) {
            object[] results = this.Invoke("VerifyEmail", new object[] {
                        email,
                        LicenseKey});
            return ((ReturnValues)(results[0]));
        }
        
        /// <remarks/>
        public void VerifyEmailAsync(string email, string LicenseKey) {
            this.VerifyEmailAsync(email, LicenseKey, null);
        }
        
        /// <remarks/>
        public void VerifyEmailAsync(string email, string LicenseKey, object userState) {
            if ((this.VerifyEmailOperationCompleted == null)) {
                this.VerifyEmailOperationCompleted = new System.Threading.SendOrPostCallback(this.OnVerifyEmailOperationCompleted);
            }
            this.InvokeAsync("VerifyEmail", new object[] {
                        email,
                        LicenseKey}, this.VerifyEmailOperationCompleted, userState);
        }
        
        private void OnVerifyEmailOperationCompleted(object arg) {
            if ((this.VerifyEmailCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.VerifyEmailCompleted(this, new VerifyEmailCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ws.cdyne.com/VerifyEmailWithTimeout", RequestNamespace="http://ws.cdyne.com/", ResponseNamespace="http://ws.cdyne.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ReturnValues VerifyEmailWithTimeout(string email, string timeout, string LicenseKey) {
            object[] results = this.Invoke("VerifyEmailWithTimeout", new object[] {
                        email,
                        timeout,
                        LicenseKey});
            return ((ReturnValues)(results[0]));
        }
        
        /// <remarks/>
        public void VerifyEmailWithTimeoutAsync(string email, string timeout, string LicenseKey) {
            this.VerifyEmailWithTimeoutAsync(email, timeout, LicenseKey, null);
        }
        
        /// <remarks/>
        public void VerifyEmailWithTimeoutAsync(string email, string timeout, string LicenseKey, object userState) {
            if ((this.VerifyEmailWithTimeoutOperationCompleted == null)) {
                this.VerifyEmailWithTimeoutOperationCompleted = new System.Threading.SendOrPostCallback(this.OnVerifyEmailWithTimeoutOperationCompleted);
            }
            this.InvokeAsync("VerifyEmailWithTimeout", new object[] {
                        email,
                        timeout,
                        LicenseKey}, this.VerifyEmailWithTimeoutOperationCompleted, userState);
        }
        
        private void OnVerifyEmailWithTimeoutOperationCompleted(object arg) {
            if ((this.VerifyEmailWithTimeoutCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.VerifyEmailWithTimeoutCompleted(this, new VerifyEmailWithTimeoutCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws.cdyne.com/")]
    public partial class ReturnValues {
        
        private bool validLicenseKeyField;
        
        private bool correctSyntaxField;
        
        private bool emailDomainFoundField;
        
        private bool emailDisposableField;
        
        private bool domainVerifiesEmailField;
        
        private bool domainAcceptsMailField;
        
        private bool emailVerifiedField;
        
        private bool timeoutField;
        
        private bool domainServersDownField;
        
        private bool goodEmailField;
        
        /// <remarks/>
        public bool ValidLicenseKey {
            get {
                return this.validLicenseKeyField;
            }
            set {
                this.validLicenseKeyField = value;
            }
        }
        
        /// <remarks/>
        public bool CorrectSyntax {
            get {
                return this.correctSyntaxField;
            }
            set {
                this.correctSyntaxField = value;
            }
        }
        
        /// <remarks/>
        public bool EmailDomainFound {
            get {
                return this.emailDomainFoundField;
            }
            set {
                this.emailDomainFoundField = value;
            }
        }
        
        /// <remarks/>
        public bool EmailDisposable {
            get {
                return this.emailDisposableField;
            }
            set {
                this.emailDisposableField = value;
            }
        }
        
        /// <remarks/>
        public bool DomainVerifiesEmail {
            get {
                return this.domainVerifiesEmailField;
            }
            set {
                this.domainVerifiesEmailField = value;
            }
        }
        
        /// <remarks/>
        public bool DomainAcceptsMail {
            get {
                return this.domainAcceptsMailField;
            }
            set {
                this.domainAcceptsMailField = value;
            }
        }
        
        /// <remarks/>
        public bool EmailVerified {
            get {
                return this.emailVerifiedField;
            }
            set {
                this.emailVerifiedField = value;
            }
        }
        
        /// <remarks/>
        public bool Timeout {
            get {
                return this.timeoutField;
            }
            set {
                this.timeoutField = value;
            }
        }
        
        /// <remarks/>
        public bool DomainServersDown {
            get {
                return this.domainServersDownField;
            }
            set {
                this.domainServersDownField = value;
            }
        }
        
        /// <remarks/>
        public bool GoodEmail {
            get {
                return this.goodEmailField;
            }
            set {
                this.goodEmailField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void VerifyMXRecordCompletedEventHandler(object sender, VerifyMXRecordCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class VerifyMXRecordCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal VerifyMXRecordCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void VerifyEmailCompletedEventHandler(object sender, VerifyEmailCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class VerifyEmailCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal VerifyEmailCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ReturnValues Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ReturnValues)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void VerifyEmailWithTimeoutCompletedEventHandler(object sender, VerifyEmailWithTimeoutCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class VerifyEmailWithTimeoutCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal VerifyEmailWithTimeoutCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ReturnValues Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ReturnValues)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591