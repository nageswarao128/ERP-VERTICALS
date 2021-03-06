//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace NAVUWP.NAVWS {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="RegisterMissionTicket_Binding", Namespace="urn:microsoft-dynamics-schemas/codeunit/RegisterMissionTicket")]
    public partial class RegisterMissionTicket : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback CallRegisterMissionTicketOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public RegisterMissionTicket() {
            this.Url = global::NAVUWP.Properties.Settings.Default.NAVUWP_NAVWS_RegisterMissionTicket;
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
        public event CallRegisterMissionTicketCompletedEventHandler CallRegisterMissionTicketCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/codeunit/RegisterMissionTicket:RegisterMissionTick" +
            "et", RequestElementName="RegisterMissionTicket", RequestNamespace="urn:microsoft-dynamics-schemas/codeunit/RegisterMissionTicket", ResponseElementName="RegisterMissionTicket_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/codeunit/RegisterMissionTicket", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void CallRegisterMissionTicket(string missionCode, System.DateTime date, string status, decimal latitude, decimal longitude, string note) {
            this.Invoke("CallRegisterMissionTicket", new object[] {
                        missionCode,
                        date,
                        status,
                        latitude,
                        longitude,
                        note});
        }
        
        /// <remarks/>
        public void CallRegisterMissionTicketAsync(string missionCode, System.DateTime date, string status, decimal latitude, decimal longitude, string note) {
            this.CallRegisterMissionTicketAsync(missionCode, date, status, latitude, longitude, note, null);
        }
        
        /// <remarks/>
        public void CallRegisterMissionTicketAsync(string missionCode, System.DateTime date, string status, decimal latitude, decimal longitude, string note, object userState) {
            if ((this.CallRegisterMissionTicketOperationCompleted == null)) {
                this.CallRegisterMissionTicketOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCallRegisterMissionTicketOperationCompleted);
            }
            this.InvokeAsync("CallRegisterMissionTicket", new object[] {
                        missionCode,
                        date,
                        status,
                        latitude,
                        longitude,
                        note}, this.CallRegisterMissionTicketOperationCompleted, userState);
        }
        
        private void OnCallRegisterMissionTicketOperationCompleted(object arg) {
            if ((this.CallRegisterMissionTicketCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CallRegisterMissionTicketCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void CallRegisterMissionTicketCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591