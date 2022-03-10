// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace body_formdata
{
    internal partial class FormdataRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of FormdataRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        public FormdataRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("http://localhost:3000");
        }

        internal HttpMessage CreateUploadFileRequest(Stream fileContent, string fileName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/formdata/stream/uploadfile", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/octet-stream, application/json");
            request.Headers.Add("Content-Type", "multipart/form-data");
            var content = new MultipartFormDataContent();
            content.Add(RequestContent.Create(fileContent), "fileContent", null);
            content.Add(new StringRequestContent(fileName), "fileName", null);
            content.ApplyToRequest(request);
            return message;
        }

        /// <summary> Upload file. </summary>
        /// <param name="fileContent"> File to upload. </param>
        /// <param name="fileName"> File name to upload. Name has to be spelled exactly as written here. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileContent"/> or <paramref name="fileName"/> is null. </exception>
        public async Task<Response<Stream>> UploadFileAsync(Stream fileContent, string fileName, CancellationToken cancellationToken = default)
        {
            if (fileContent == null)
            {
                throw new ArgumentNullException(nameof(fileContent));
            }
            if (fileName == null)
            {
                throw new ArgumentNullException(nameof(fileName));
            }

            using var message = CreateUploadFileRequest(fileContent, fileName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        var value = message.ExtractResponseContent();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Upload file. </summary>
        /// <param name="fileContent"> File to upload. </param>
        /// <param name="fileName"> File name to upload. Name has to be spelled exactly as written here. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileContent"/> or <paramref name="fileName"/> is null. </exception>
        public Response<Stream> UploadFile(Stream fileContent, string fileName, CancellationToken cancellationToken = default)
        {
            if (fileContent == null)
            {
                throw new ArgumentNullException(nameof(fileContent));
            }
            if (fileName == null)
            {
                throw new ArgumentNullException(nameof(fileName));
            }

            using var message = CreateUploadFileRequest(fileContent, fileName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        var value = message.ExtractResponseContent();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUploadFileViaBodyRequest(Stream fileContent)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/formdata/stream/uploadfile", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/octet-stream, application/json");
            request.Headers.Add("Content-Type", "application/octet-stream");
            request.Content = RequestContent.Create(fileContent);
            return message;
        }

        /// <summary> Upload file. </summary>
        /// <param name="fileContent"> File to upload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileContent"/> is null. </exception>
        public async Task<Response<Stream>> UploadFileViaBodyAsync(Stream fileContent, CancellationToken cancellationToken = default)
        {
            if (fileContent == null)
            {
                throw new ArgumentNullException(nameof(fileContent));
            }

            using var message = CreateUploadFileViaBodyRequest(fileContent);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        var value = message.ExtractResponseContent();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Upload file. </summary>
        /// <param name="fileContent"> File to upload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileContent"/> is null. </exception>
        public Response<Stream> UploadFileViaBody(Stream fileContent, CancellationToken cancellationToken = default)
        {
            if (fileContent == null)
            {
                throw new ArgumentNullException(nameof(fileContent));
            }

            using var message = CreateUploadFileViaBodyRequest(fileContent);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        var value = message.ExtractResponseContent();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUploadFilesRequest(IEnumerable<Stream> fileContent)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/formdata/stream/uploadfiles", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/octet-stream, application/json");
            request.Headers.Add("Content-Type", "multipart/form-data");
            var content = new MultipartFormDataContent();
            foreach (var value in fileContent)
            {
                content.Add(RequestContent.Create(value), "fileContent", null);
            }
            content.ApplyToRequest(request);
            return message;
        }

        /// <summary> Upload multiple files. </summary>
        /// <param name="fileContent"> Files to upload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileContent"/> is null. </exception>
        public async Task<Response<Stream>> UploadFilesAsync(IEnumerable<Stream> fileContent, CancellationToken cancellationToken = default)
        {
            if (fileContent == null)
            {
                throw new ArgumentNullException(nameof(fileContent));
            }

            using var message = CreateUploadFilesRequest(fileContent);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        var value = message.ExtractResponseContent();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Upload multiple files. </summary>
        /// <param name="fileContent"> Files to upload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileContent"/> is null. </exception>
        public Response<Stream> UploadFiles(IEnumerable<Stream> fileContent, CancellationToken cancellationToken = default)
        {
            if (fileContent == null)
            {
                throw new ArgumentNullException(nameof(fileContent));
            }

            using var message = CreateUploadFilesRequest(fileContent);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        var value = message.ExtractResponseContent();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
