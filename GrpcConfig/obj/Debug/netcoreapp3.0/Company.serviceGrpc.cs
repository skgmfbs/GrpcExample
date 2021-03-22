// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/company.service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcConfig.Services {
  /// <summary>
  /// The company service definition.
  /// </summary>
  public static partial class CompanyService
  {
    static readonly string __ServiceName = "GrpcConfig.Services.CompanyService";

    static readonly grpc::Marshaller<global::GrpcConfig.Definition.GetCompaniesRequest> __Marshaller_GrpcConfig_Definition_GetCompaniesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcConfig.Definition.GetCompaniesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcConfig.Definition.CompaniesResponse> __Marshaller_GrpcConfig_Definition_CompaniesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcConfig.Definition.CompaniesResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcConfig.Definition.GetCompanyByIdRequest> __Marshaller_GrpcConfig_Definition_GetCompanyByIdRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcConfig.Definition.GetCompanyByIdRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcConfig.Definition.CompanyResponse> __Marshaller_GrpcConfig_Definition_CompanyResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcConfig.Definition.CompanyResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcConfig.Definition.GetCompaniesRequest, global::GrpcConfig.Definition.CompaniesResponse> __Method_GetCompanies = new grpc::Method<global::GrpcConfig.Definition.GetCompaniesRequest, global::GrpcConfig.Definition.CompaniesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCompanies",
        __Marshaller_GrpcConfig_Definition_GetCompaniesRequest,
        __Marshaller_GrpcConfig_Definition_CompaniesResponse);

    static readonly grpc::Method<global::GrpcConfig.Definition.GetCompanyByIdRequest, global::GrpcConfig.Definition.CompanyResponse> __Method_GetCompanyById = new grpc::Method<global::GrpcConfig.Definition.GetCompanyByIdRequest, global::GrpcConfig.Definition.CompanyResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCompanyById",
        __Marshaller_GrpcConfig_Definition_GetCompanyByIdRequest,
        __Marshaller_GrpcConfig_Definition_CompanyResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcConfig.Services.CompanyServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CompanyService</summary>
    [grpc::BindServiceMethod(typeof(CompanyService), "BindService")]
    public abstract partial class CompanyServiceBase
    {
      /// <summary>
      /// get all companies.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::GrpcConfig.Definition.CompaniesResponse> GetCompanies(global::GrpcConfig.Definition.GetCompaniesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// get company by id.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::GrpcConfig.Definition.CompanyResponse> GetCompanyById(global::GrpcConfig.Definition.GetCompanyByIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CompanyService</summary>
    public partial class CompanyServiceClient : grpc::ClientBase<CompanyServiceClient>
    {
      /// <summary>Creates a new client for CompanyService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CompanyServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CompanyService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CompanyServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CompanyServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CompanyServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// get all companies.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::GrpcConfig.Definition.CompaniesResponse GetCompanies(global::GrpcConfig.Definition.GetCompaniesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCompanies(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// get all companies.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::GrpcConfig.Definition.CompaniesResponse GetCompanies(global::GrpcConfig.Definition.GetCompaniesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCompanies, null, options, request);
      }
      /// <summary>
      /// get all companies.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::GrpcConfig.Definition.CompaniesResponse> GetCompaniesAsync(global::GrpcConfig.Definition.GetCompaniesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCompaniesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// get all companies.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::GrpcConfig.Definition.CompaniesResponse> GetCompaniesAsync(global::GrpcConfig.Definition.GetCompaniesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCompanies, null, options, request);
      }
      /// <summary>
      /// get company by id.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::GrpcConfig.Definition.CompanyResponse GetCompanyById(global::GrpcConfig.Definition.GetCompanyByIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCompanyById(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// get company by id.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::GrpcConfig.Definition.CompanyResponse GetCompanyById(global::GrpcConfig.Definition.GetCompanyByIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCompanyById, null, options, request);
      }
      /// <summary>
      /// get company by id.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::GrpcConfig.Definition.CompanyResponse> GetCompanyByIdAsync(global::GrpcConfig.Definition.GetCompanyByIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCompanyByIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// get company by id.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::GrpcConfig.Definition.CompanyResponse> GetCompanyByIdAsync(global::GrpcConfig.Definition.GetCompanyByIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCompanyById, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CompanyServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CompanyServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CompanyServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetCompanies, serviceImpl.GetCompanies)
          .AddMethod(__Method_GetCompanyById, serviceImpl.GetCompanyById).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CompanyServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetCompanies, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcConfig.Definition.GetCompaniesRequest, global::GrpcConfig.Definition.CompaniesResponse>(serviceImpl.GetCompanies));
      serviceBinder.AddMethod(__Method_GetCompanyById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcConfig.Definition.GetCompanyByIdRequest, global::GrpcConfig.Definition.CompanyResponse>(serviceImpl.GetCompanyById));
    }

  }
}
#endregion