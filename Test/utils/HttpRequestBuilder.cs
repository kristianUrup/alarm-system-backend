using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;

namespace Test {
    public class HttpRequestBuilder {
        private Dictionary<string, StringValues> query;
        private object body;

        public HttpRequestBuilder() {}

        public HttpRequestBuilder Query(string key, string value) {
            this.query = new Dictionary<string, StringValues>
            {
                { key, value }
            };
            return this;
        }

        public HttpRequestBuilder Body(object body) {
            this.body = body;
            return this;
        }

        public HttpRequest Build() {

            var req = TestFactory.CreateHttpRequest();

            if (query != null) {
                req.Query = new QueryCollection(query);
            }

            if (body != null) {
                var json = JsonConvert.SerializeObject(body);
                var stream = new MemoryStream();
                var writer = new StreamWriter(stream);
                writer.Write(json);
                writer.Flush();
                stream.Position = 0;

                req.Body = stream;
            }

            return req;
        }
    }
}