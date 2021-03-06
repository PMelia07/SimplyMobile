﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by SlSvcUtil, version 5.0.61118.0
// 
namespace SimplyMobile.Plugins.WeatherWcfService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DefaultFaultContract", Namespace="http://GOTLServices.FaultContracts/2008/01")]
    public partial class DefaultFaultContract : object
    {
        
        private int ErrorIdField;
        
        private string ErrorMessageField;
        
        private System.Guid CorrelationIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int ErrorId
        {
            get
            {
                return this.ErrorIdField;
            }
            set
            {
                this.ErrorIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string ErrorMessage
        {
            get
            {
                return this.ErrorMessageField;
            }
            set
            {
                this.ErrorMessageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public System.Guid CorrelationId
        {
            get
            {
                return this.CorrelationIdField;
            }
            set
            {
                this.CorrelationIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Weather", Namespace="http://www.restfulwebservices.net/DataContracts/2008/01")]
    public partial class Weather : object
    {
        
        private string LocationField;
        
        private string TimeField;
        
        private string WindField;
        
        private string VisibilityField;
        
        private string SkyConditionsField;
        
        private string TemperatureField;
        
        private string DewPointField;
        
        private string RelativeHumidityField;
        
        private string PressureField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Location
        {
            get
            {
                return this.LocationField;
            }
            set
            {
                this.LocationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Time
        {
            get
            {
                return this.TimeField;
            }
            set
            {
                this.TimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Wind
        {
            get
            {
                return this.WindField;
            }
            set
            {
                this.WindField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public string Visibility
        {
            get
            {
                return this.VisibilityField;
            }
            set
            {
                this.VisibilityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public string SkyConditions
        {
            get
            {
                return this.SkyConditionsField;
            }
            set
            {
                this.SkyConditionsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public string Temperature
        {
            get
            {
                return this.TemperatureField;
            }
            set
            {
                this.TemperatureField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public string DewPoint
        {
            get
            {
                return this.DewPointField;
            }
            set
            {
                this.DewPointField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=7)]
        public string RelativeHumidity
        {
            get
            {
                return this.RelativeHumidityField;
            }
            set
            {
                this.RelativeHumidityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=8)]
        public string Pressure
        {
            get
            {
                return this.PressureField;
            }
            set
            {
                this.PressureField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.restfulwebservices.net/ServiceContracts/2008/01", ConfigurationName="SimplyMobile.Plugins.WeatherWcfService.IWeatherForecastService")]
    public interface IWeatherForecastService
    {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="GetCitiesByCountry", ReplyAction="http://www.restfulwebservices.net/ServiceContracts/2008/01/IWeatherForecastServic" +
            "e/GetCitiesByCountryResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SimplyMobile.Plugins.WeatherWcfService.DefaultFaultContract), Action="http://www.restfulwebservices.net/ServiceContracts/2008/01/IWeatherForecastServic" +
            "e/GetCitiesByCountryDefaultFaultContractFault", Name="DefaultFaultContract", Namespace="http://GOTLServices.FaultContracts/2008/01")]
        System.IAsyncResult BeginGetCitiesByCountry(string Country, System.AsyncCallback callback, object asyncState);
        
        string[] EndGetCitiesByCountry(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="GetForecastByCity", ReplyAction="http://www.restfulwebservices.net/ServiceContracts/2008/01/IWeatherForecastServic" +
            "e/GetForecastByCityResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SimplyMobile.Plugins.WeatherWcfService.DefaultFaultContract), Action="http://www.restfulwebservices.net/ServiceContracts/2008/01/IWeatherForecastServic" +
            "e/GetForecastByCityDefaultFaultContractFault", Name="DefaultFaultContract", Namespace="http://GOTLServices.FaultContracts/2008/01")]
        System.IAsyncResult BeginGetForecastByCity(string City, string Country, System.AsyncCallback callback, object asyncState);
        
        SimplyMobile.Plugins.WeatherWcfService.Weather EndGetForecastByCity(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWeatherForecastServiceChannel : SimplyMobile.Plugins.WeatherWcfService.IWeatherForecastService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetCitiesByCountryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        
        private object[] results;
        
        public GetCitiesByCountryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState)
        {
            this.results = results;
        }
        
        public string[] Result
        {
            get
            {
                base.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetForecastByCityCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        
        private object[] results;
        
        public GetForecastByCityCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState)
        {
            this.results = results;
        }
        
        public SimplyMobile.Plugins.WeatherWcfService.Weather Result
        {
            get
            {
                base.RaiseExceptionIfNecessary();
                return ((SimplyMobile.Plugins.WeatherWcfService.Weather)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WeatherForecastServiceClient : System.ServiceModel.ClientBase<SimplyMobile.Plugins.WeatherWcfService.IWeatherForecastService>, SimplyMobile.Plugins.WeatherWcfService.IWeatherForecastService
    {
        
        private BeginOperationDelegate onBeginGetCitiesByCountryDelegate;
        
        private EndOperationDelegate onEndGetCitiesByCountryDelegate;
        
        private System.Threading.SendOrPostCallback onGetCitiesByCountryCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetForecastByCityDelegate;
        
        private EndOperationDelegate onEndGetForecastByCityDelegate;
        
        private System.Threading.SendOrPostCallback onGetForecastByCityCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public WeatherForecastServiceClient()
        {
        }
        
        public WeatherForecastServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public WeatherForecastServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public WeatherForecastServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public WeatherForecastServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Net.CookieContainer CookieContainer
        {
            get
            {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null))
                {
                    return httpCookieContainerManager.CookieContainer;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null))
                {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else
                {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<GetCitiesByCountryCompletedEventArgs> GetCitiesByCountryCompleted;
        
        public event System.EventHandler<GetForecastByCityCompletedEventArgs> GetForecastByCityCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SimplyMobile.Plugins.WeatherWcfService.IWeatherForecastService.BeginGetCitiesByCountry(string Country, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginGetCitiesByCountry(Country, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string[] SimplyMobile.Plugins.WeatherWcfService.IWeatherForecastService.EndGetCitiesByCountry(System.IAsyncResult result)
        {
            return base.Channel.EndGetCitiesByCountry(result);
        }
        
        private System.IAsyncResult OnBeginGetCitiesByCountry(object[] inValues, System.AsyncCallback callback, object asyncState)
        {
            string Country = ((string)(inValues[0]));
            return ((SimplyMobile.Plugins.WeatherWcfService.IWeatherForecastService)(this)).BeginGetCitiesByCountry(Country, callback, asyncState);
        }
        
        private object[] OnEndGetCitiesByCountry(System.IAsyncResult result)
        {
            string[] retVal = ((SimplyMobile.Plugins.WeatherWcfService.IWeatherForecastService)(this)).EndGetCitiesByCountry(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetCitiesByCountryCompleted(object state)
        {
            if ((this.GetCitiesByCountryCompleted != null))
            {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetCitiesByCountryCompleted(this, new GetCitiesByCountryCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetCitiesByCountryAsync(string Country)
        {
            this.GetCitiesByCountryAsync(Country, null);
        }
        
        public void GetCitiesByCountryAsync(string Country, object userState)
        {
            if ((this.onBeginGetCitiesByCountryDelegate == null))
            {
                this.onBeginGetCitiesByCountryDelegate = new BeginOperationDelegate(this.OnBeginGetCitiesByCountry);
            }
            if ((this.onEndGetCitiesByCountryDelegate == null))
            {
                this.onEndGetCitiesByCountryDelegate = new EndOperationDelegate(this.OnEndGetCitiesByCountry);
            }
            if ((this.onGetCitiesByCountryCompletedDelegate == null))
            {
                this.onGetCitiesByCountryCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetCitiesByCountryCompleted);
            }
            base.InvokeAsync(this.onBeginGetCitiesByCountryDelegate, new object[] {
                        Country}, this.onEndGetCitiesByCountryDelegate, this.onGetCitiesByCountryCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SimplyMobile.Plugins.WeatherWcfService.IWeatherForecastService.BeginGetForecastByCity(string City, string Country, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginGetForecastByCity(City, Country, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SimplyMobile.Plugins.WeatherWcfService.Weather SimplyMobile.Plugins.WeatherWcfService.IWeatherForecastService.EndGetForecastByCity(System.IAsyncResult result)
        {
            return base.Channel.EndGetForecastByCity(result);
        }
        
        private System.IAsyncResult OnBeginGetForecastByCity(object[] inValues, System.AsyncCallback callback, object asyncState)
        {
            string City = ((string)(inValues[0]));
            string Country = ((string)(inValues[1]));
            return ((SimplyMobile.Plugins.WeatherWcfService.IWeatherForecastService)(this)).BeginGetForecastByCity(City, Country, callback, asyncState);
        }
        
        private object[] OnEndGetForecastByCity(System.IAsyncResult result)
        {
            SimplyMobile.Plugins.WeatherWcfService.Weather retVal = ((SimplyMobile.Plugins.WeatherWcfService.IWeatherForecastService)(this)).EndGetForecastByCity(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetForecastByCityCompleted(object state)
        {
            if ((this.GetForecastByCityCompleted != null))
            {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetForecastByCityCompleted(this, new GetForecastByCityCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetForecastByCityAsync(string City, string Country)
        {
            this.GetForecastByCityAsync(City, Country, null);
        }
        
        public void GetForecastByCityAsync(string City, string Country, object userState)
        {
            if ((this.onBeginGetForecastByCityDelegate == null))
            {
                this.onBeginGetForecastByCityDelegate = new BeginOperationDelegate(this.OnBeginGetForecastByCity);
            }
            if ((this.onEndGetForecastByCityDelegate == null))
            {
                this.onEndGetForecastByCityDelegate = new EndOperationDelegate(this.OnEndGetForecastByCity);
            }
            if ((this.onGetForecastByCityCompletedDelegate == null))
            {
                this.onGetForecastByCityCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetForecastByCityCompleted);
            }
            base.InvokeAsync(this.onBeginGetForecastByCityDelegate, new object[] {
                        City,
                        Country}, this.onEndGetForecastByCityDelegate, this.onGetForecastByCityCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState)
        {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result)
        {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state)
        {
            if ((this.OpenCompleted != null))
            {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync()
        {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState)
        {
            if ((this.onBeginOpenDelegate == null))
            {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null))
            {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null))
            {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState)
        {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result)
        {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state)
        {
            if ((this.CloseCompleted != null))
            {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync()
        {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState)
        {
            if ((this.onBeginCloseDelegate == null))
            {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null))
            {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null))
            {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override SimplyMobile.Plugins.WeatherWcfService.IWeatherForecastService CreateChannel()
        {
            return new WeatherForecastServiceClientChannel(this);
        }
        
        private class WeatherForecastServiceClientChannel : ChannelBase<SimplyMobile.Plugins.WeatherWcfService.IWeatherForecastService>, SimplyMobile.Plugins.WeatherWcfService.IWeatherForecastService
        {
            
            public WeatherForecastServiceClientChannel(System.ServiceModel.ClientBase<SimplyMobile.Plugins.WeatherWcfService.IWeatherForecastService> client) : 
                    base(client)
            {
            }
            
            public System.IAsyncResult BeginGetCitiesByCountry(string Country, System.AsyncCallback callback, object asyncState)
            {
                object[] _args = new object[1];
                _args[0] = Country;
                System.IAsyncResult _result = base.BeginInvoke("GetCitiesByCountry", _args, callback, asyncState);
                return _result;
            }
            
            public string[] EndGetCitiesByCountry(System.IAsyncResult result)
            {
                object[] _args = new object[0];
                string[] _result = ((string[])(base.EndInvoke("GetCitiesByCountry", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGetForecastByCity(string City, string Country, System.AsyncCallback callback, object asyncState)
            {
                object[] _args = new object[2];
                _args[0] = City;
                _args[1] = Country;
                System.IAsyncResult _result = base.BeginInvoke("GetForecastByCity", _args, callback, asyncState);
                return _result;
            }
            
            public SimplyMobile.Plugins.WeatherWcfService.Weather EndGetForecastByCity(System.IAsyncResult result)
            {
                object[] _args = new object[0];
                SimplyMobile.Plugins.WeatherWcfService.Weather _result = ((SimplyMobile.Plugins.WeatherWcfService.Weather)(base.EndInvoke("GetForecastByCity", _args, result)));
                return _result;
            }
        }
    }
}
