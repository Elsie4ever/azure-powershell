// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Extensions;

    /// <summary>The workflow run action properties.</summary>
    public partial class WorkflowRunActionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowRunActionProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowRunActionPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Code" /> property.</summary>
        private string _code;

        /// <summary>Gets the code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public string Code { get => this._code; }

        /// <summary>Backing field for <see cref="Correlation" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IRunActionCorrelation _correlation;

        /// <summary>The correlation properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IRunActionCorrelation Correlation { get => (this._correlation = this._correlation ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.RunActionCorrelation()); set => this._correlation = value; }

        /// <summary>The action tracking identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string CorrelationActionTrackingId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IRunActionCorrelationInternal)Correlation).ActionTrackingId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IRunActionCorrelationInternal)Correlation).ActionTrackingId = value ?? null; }

        /// <summary>The client keywords.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string[] CorrelationClientKeyword { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IRunCorrelationInternal)Correlation).ClientKeyword; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IRunCorrelationInternal)Correlation).ClientKeyword = value ?? null /* arrayOf */; }

        /// <summary>The client tracking identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string CorrelationClientTrackingId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IRunCorrelationInternal)Correlation).ClientTrackingId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IRunCorrelationInternal)Correlation).ClientTrackingId = value ?? null; }

        /// <summary>Backing field for <see cref="EndTime" /> property.</summary>
        private global::System.DateTime? _endTime;

        /// <summary>Gets the end time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public global::System.DateTime? EndTime { get => this._endTime; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IAny _error;

        /// <summary>Gets the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IAny Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Any()); }

        /// <summary>The content size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public long? InputLinkContentSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)InputsLink).ContentSize; }

        /// <summary>The content version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string InputLinkContentVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)InputsLink).ContentVersion; }

        /// <summary>The metadata.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IAny InputLinkMetadata { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)InputsLink).Metadata; }

        /// <summary>The content link URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string InputLinkUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)InputsLink).Uri; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)InputsLink).Uri = value ?? null; }

        /// <summary>Backing field for <see cref="InputsLink" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLink _inputsLink;

        /// <summary>Gets the link to inputs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLink InputsLink { get => (this._inputsLink = this._inputsLink ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ContentLink()); }

        /// <summary>The algorithm of the content hash.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string InputsLinkContentHashAlgorithm { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)InputsLink).ContentHashAlgorithm; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)InputsLink).ContentHashAlgorithm = value ?? null; }

        /// <summary>The value of the content hash.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string InputsLinkContentHashValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)InputsLink).ContentHashValue; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)InputsLink).ContentHashValue = value ?? null; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowRunActionPropertiesInternal.Code { get => this._code; set { {_code = value;} } }

        /// <summary>Internal Acessors for Correlation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IRunActionCorrelation Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowRunActionPropertiesInternal.Correlation { get => (this._correlation = this._correlation ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.RunActionCorrelation()); set { {_correlation = value;} } }

        /// <summary>Internal Acessors for EndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowRunActionPropertiesInternal.EndTime { get => this._endTime; set { {_endTime = value;} } }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IAny Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowRunActionPropertiesInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Any()); set { {_error = value;} } }

        /// <summary>Internal Acessors for InputLinkContentHash</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentHash Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowRunActionPropertiesInternal.InputLinkContentHash { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)InputsLink).ContentHash; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)InputsLink).ContentHash = value; }

        /// <summary>Internal Acessors for InputLinkContentSize</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowRunActionPropertiesInternal.InputLinkContentSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)InputsLink).ContentSize; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)InputsLink).ContentSize = value; }

        /// <summary>Internal Acessors for InputLinkContentVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowRunActionPropertiesInternal.InputLinkContentVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)InputsLink).ContentVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)InputsLink).ContentVersion = value; }

        /// <summary>Internal Acessors for InputLinkMetadata</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IAny Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowRunActionPropertiesInternal.InputLinkMetadata { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)InputsLink).Metadata; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)InputsLink).Metadata = value; }

        /// <summary>Internal Acessors for InputsLink</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLink Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowRunActionPropertiesInternal.InputsLink { get => (this._inputsLink = this._inputsLink ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ContentLink()); set { {_inputsLink = value;} } }

        /// <summary>Internal Acessors for OutputLinkContentHash</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentHash Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowRunActionPropertiesInternal.OutputLinkContentHash { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)OutputsLink).ContentHash; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)OutputsLink).ContentHash = value; }

        /// <summary>Internal Acessors for OutputLinkContentSize</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowRunActionPropertiesInternal.OutputLinkContentSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)OutputsLink).ContentSize; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)OutputsLink).ContentSize = value; }

        /// <summary>Internal Acessors for OutputLinkContentVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowRunActionPropertiesInternal.OutputLinkContentVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)OutputsLink).ContentVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)OutputsLink).ContentVersion = value; }

        /// <summary>Internal Acessors for OutputLinkMetadata</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IAny Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowRunActionPropertiesInternal.OutputLinkMetadata { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)OutputsLink).Metadata; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)OutputsLink).Metadata = value; }

        /// <summary>Internal Acessors for OutputsLink</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLink Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowRunActionPropertiesInternal.OutputsLink { get => (this._outputsLink = this._outputsLink ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ContentLink()); set { {_outputsLink = value;} } }

        /// <summary>Internal Acessors for StartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowRunActionPropertiesInternal.StartTime { get => this._startTime; set { {_startTime = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.WorkflowStatus? Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowRunActionPropertiesInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Internal Acessors for TrackedProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IAny Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowRunActionPropertiesInternal.TrackedProperty { get => (this._trackedProperty = this._trackedProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Any()); set { {_trackedProperty = value;} } }

        /// <summary>Internal Acessors for TrackingId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowRunActionPropertiesInternal.TrackingId { get => this._trackingId; set { {_trackingId = value;} } }

        /// <summary>The content size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public long? OutputLinkContentSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)OutputsLink).ContentSize; }

        /// <summary>The content version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string OutputLinkContentVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)OutputsLink).ContentVersion; }

        /// <summary>The metadata.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IAny OutputLinkMetadata { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)OutputsLink).Metadata; }

        /// <summary>The content link URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string OutputLinkUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)OutputsLink).Uri; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)OutputsLink).Uri = value ?? null; }

        /// <summary>Backing field for <see cref="OutputsLink" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLink _outputsLink;

        /// <summary>Gets the link to outputs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLink OutputsLink { get => (this._outputsLink = this._outputsLink ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ContentLink()); }

        /// <summary>The algorithm of the content hash.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string OutputsLinkContentHashAlgorithm { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)OutputsLink).ContentHashAlgorithm; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)OutputsLink).ContentHashAlgorithm = value ?? null; }

        /// <summary>The value of the content hash.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string OutputsLinkContentHashValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)OutputsLink).ContentHashValue; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLinkInternal)OutputsLink).ContentHashValue = value ?? null; }

        /// <summary>Backing field for <see cref="RetryHistory" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IRetryHistory[] _retryHistory;

        /// <summary>Gets the retry histories.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IRetryHistory[] RetryHistory { get => this._retryHistory; set => this._retryHistory = value; }

        /// <summary>Backing field for <see cref="StartTime" /> property.</summary>
        private global::System.DateTime? _startTime;

        /// <summary>Gets the start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public global::System.DateTime? StartTime { get => this._startTime; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.WorkflowStatus? _status;

        /// <summary>Gets the status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.WorkflowStatus? Status { get => this._status; }

        /// <summary>Backing field for <see cref="TrackedProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IAny _trackedProperty;

        /// <summary>Gets the tracked properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IAny TrackedProperty { get => (this._trackedProperty = this._trackedProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Any()); }

        /// <summary>Backing field for <see cref="TrackingId" /> property.</summary>
        private string _trackingId;

        /// <summary>Gets the tracking id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public string TrackingId { get => this._trackingId; }

        /// <summary>Creates an new <see cref="WorkflowRunActionProperties" /> instance.</summary>
        public WorkflowRunActionProperties()
        {

        }
    }
    /// The workflow run action properties.
    public partial interface IWorkflowRunActionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IJsonSerializable
    {
        /// <summary>Gets the code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>The action tracking identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The action tracking identifier.",
        SerializedName = @"actionTrackingId",
        PossibleTypes = new [] { typeof(string) })]
        string CorrelationActionTrackingId { get; set; }
        /// <summary>The client keywords.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The client keywords.",
        SerializedName = @"clientKeywords",
        PossibleTypes = new [] { typeof(string) })]
        string[] CorrelationClientKeyword { get; set; }
        /// <summary>The client tracking identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The client tracking identifier.",
        SerializedName = @"clientTrackingId",
        PossibleTypes = new [] { typeof(string) })]
        string CorrelationClientTrackingId { get; set; }
        /// <summary>Gets the end time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the end time.",
        SerializedName = @"endTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EndTime { get;  }
        /// <summary>Gets the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the error.",
        SerializedName = @"error",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IAny) })]
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IAny Error { get;  }
        /// <summary>The content size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The content size.",
        SerializedName = @"contentSize",
        PossibleTypes = new [] { typeof(long) })]
        long? InputLinkContentSize { get;  }
        /// <summary>The content version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The content version.",
        SerializedName = @"contentVersion",
        PossibleTypes = new [] { typeof(string) })]
        string InputLinkContentVersion { get;  }
        /// <summary>The metadata.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The metadata.",
        SerializedName = @"metadata",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IAny) })]
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IAny InputLinkMetadata { get;  }
        /// <summary>The content link URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The content link URI.",
        SerializedName = @"uri",
        PossibleTypes = new [] { typeof(string) })]
        string InputLinkUri { get; set; }
        /// <summary>The algorithm of the content hash.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The algorithm of the content hash.",
        SerializedName = @"algorithm",
        PossibleTypes = new [] { typeof(string) })]
        string InputsLinkContentHashAlgorithm { get; set; }
        /// <summary>The value of the content hash.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value of the content hash.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string InputsLinkContentHashValue { get; set; }
        /// <summary>The content size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The content size.",
        SerializedName = @"contentSize",
        PossibleTypes = new [] { typeof(long) })]
        long? OutputLinkContentSize { get;  }
        /// <summary>The content version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The content version.",
        SerializedName = @"contentVersion",
        PossibleTypes = new [] { typeof(string) })]
        string OutputLinkContentVersion { get;  }
        /// <summary>The metadata.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The metadata.",
        SerializedName = @"metadata",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IAny) })]
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IAny OutputLinkMetadata { get;  }
        /// <summary>The content link URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The content link URI.",
        SerializedName = @"uri",
        PossibleTypes = new [] { typeof(string) })]
        string OutputLinkUri { get; set; }
        /// <summary>The algorithm of the content hash.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The algorithm of the content hash.",
        SerializedName = @"algorithm",
        PossibleTypes = new [] { typeof(string) })]
        string OutputsLinkContentHashAlgorithm { get; set; }
        /// <summary>The value of the content hash.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value of the content hash.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string OutputsLinkContentHashValue { get; set; }
        /// <summary>Gets the retry histories.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets the retry histories.",
        SerializedName = @"retryHistory",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IRetryHistory) })]
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IRetryHistory[] RetryHistory { get; set; }
        /// <summary>Gets the start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the start time.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartTime { get;  }
        /// <summary>Gets the status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.WorkflowStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.WorkflowStatus? Status { get;  }
        /// <summary>Gets the tracked properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the tracked properties.",
        SerializedName = @"trackedProperties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IAny) })]
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IAny TrackedProperty { get;  }
        /// <summary>Gets the tracking id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the tracking id.",
        SerializedName = @"trackingId",
        PossibleTypes = new [] { typeof(string) })]
        string TrackingId { get;  }

    }
    /// The workflow run action properties.
    internal partial interface IWorkflowRunActionPropertiesInternal

    {
        /// <summary>Gets the code.</summary>
        string Code { get; set; }
        /// <summary>The correlation properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IRunActionCorrelation Correlation { get; set; }
        /// <summary>The action tracking identifier.</summary>
        string CorrelationActionTrackingId { get; set; }
        /// <summary>The client keywords.</summary>
        string[] CorrelationClientKeyword { get; set; }
        /// <summary>The client tracking identifier.</summary>
        string CorrelationClientTrackingId { get; set; }
        /// <summary>Gets the end time.</summary>
        global::System.DateTime? EndTime { get; set; }
        /// <summary>Gets the error.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IAny Error { get; set; }
        /// <summary>The content hash.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentHash InputLinkContentHash { get; set; }
        /// <summary>The content size.</summary>
        long? InputLinkContentSize { get; set; }
        /// <summary>The content version.</summary>
        string InputLinkContentVersion { get; set; }
        /// <summary>The metadata.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IAny InputLinkMetadata { get; set; }
        /// <summary>The content link URI.</summary>
        string InputLinkUri { get; set; }
        /// <summary>Gets the link to inputs.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLink InputsLink { get; set; }
        /// <summary>The algorithm of the content hash.</summary>
        string InputsLinkContentHashAlgorithm { get; set; }
        /// <summary>The value of the content hash.</summary>
        string InputsLinkContentHashValue { get; set; }
        /// <summary>The content hash.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentHash OutputLinkContentHash { get; set; }
        /// <summary>The content size.</summary>
        long? OutputLinkContentSize { get; set; }
        /// <summary>The content version.</summary>
        string OutputLinkContentVersion { get; set; }
        /// <summary>The metadata.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IAny OutputLinkMetadata { get; set; }
        /// <summary>The content link URI.</summary>
        string OutputLinkUri { get; set; }
        /// <summary>Gets the link to outputs.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLink OutputsLink { get; set; }
        /// <summary>The algorithm of the content hash.</summary>
        string OutputsLinkContentHashAlgorithm { get; set; }
        /// <summary>The value of the content hash.</summary>
        string OutputsLinkContentHashValue { get; set; }
        /// <summary>Gets the retry histories.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IRetryHistory[] RetryHistory { get; set; }
        /// <summary>Gets the start time.</summary>
        global::System.DateTime? StartTime { get; set; }
        /// <summary>Gets the status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.WorkflowStatus? Status { get; set; }
        /// <summary>Gets the tracked properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IAny TrackedProperty { get; set; }
        /// <summary>Gets the tracking id.</summary>
        string TrackingId { get; set; }

    }
}