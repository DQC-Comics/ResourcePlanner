﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using System.Net.Http;
using Microsoft.Rest;
using OrderData;

namespace OrderData
{
    public partial class Unknowntype : ServiceClient<Unknowntype>, IUnknowntype
    {
        private Uri _baseUri;
        
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
            set { this._baseUri = value; }
        }
        
        private ServiceClientCredentials _credentials;
        
        /// <summary>
        /// Credentials for authenticating with the service.
        /// </summary>
        public ServiceClientCredentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }
        
        private IBookings _bookings;
        
        public virtual IBookings Bookings
        {
            get { return this._bookings; }
        }
        
        private IHeroes _heroes;
        
        public virtual IHeroes Heroes
        {
            get { return this._heroes; }
        }
        
        private ISkills _skills;
        
        public virtual ISkills Skills
        {
            get { return this._skills; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Unknowntype class.
        /// </summary>
        public Unknowntype()
            : base()
        {
            this._bookings = new Bookings(this);
            this._heroes = new Heroes(this);
            this._skills = new Skills(this);
            this._baseUri = new Uri("https://dqccomics-webapi.azurewebsites.net");
        }
        
        /// <summary>
        /// Initializes a new instance of the Unknowntype class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public Unknowntype(params DelegatingHandler[] handlers)
            : base(handlers)
        {
            this._bookings = new Bookings(this);
            this._heroes = new Heroes(this);
            this._skills = new Skills(this);
            this._baseUri = new Uri("https://dqccomics-webapi.azurewebsites.net");
        }
        
        /// <summary>
        /// Initializes a new instance of the Unknowntype class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public Unknowntype(HttpClientHandler rootHandler, params DelegatingHandler[] handlers)
            : base(rootHandler, handlers)
        {
            this._bookings = new Bookings(this);
            this._heroes = new Heroes(this);
            this._skills = new Skills(this);
            this._baseUri = new Uri("https://dqccomics-webapi.azurewebsites.net");
        }
        
        /// <summary>
        /// Initializes a new instance of the Unknowntype class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public Unknowntype(Uri baseUri, params DelegatingHandler[] handlers)
            : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._baseUri = baseUri;
        }
        
        /// <summary>
        /// Initializes a new instance of the Unknowntype class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials for authenticating with the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public Unknowntype(ServiceClientCredentials credentials, params DelegatingHandler[] handlers)
            : this(handlers)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
        }
        
        /// <summary>
        /// Initializes a new instance of the Unknowntype class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials for authenticating with the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public Unknowntype(Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers)
            : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._baseUri = baseUri;
            this._credentials = credentials;
            
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
        }
    }
}
