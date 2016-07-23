﻿using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace System.Net
{
    internal static class HttpKnownHeaderNames
    {
        // HttpKnownHeaderNames 상수들의 값을 Key로 설정 및 HttpRequestHeader로 캐스팅가능한 변수이름을 Value로 딕셔너리 생성
        public static Dictionary<string, HttpRequestHeader> ValueNames
            = typeof(HttpKnownHeaderNames)
                .GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)        // 모든 정적 필드
                .Where(ci => ci.IsLiteral && !ci.IsInitOnly && ci.Name.ToEnum<HttpRequestHeader>().HasValue) // 상수, 캐스팅 체크
                .ToDictionary(
                    ci => ci.GetValue(null).ToString(),
                    ci => ci.Name.ToEnum<HttpRequestHeader>().Value);

        public const string CacheControl = "Cache-Control";
        public const string Connection = "Connection";
        public const string Date = "Date";
        public const string KeepAlive = "Keep-Alive";
        public const string Pragma = "Pragma";
        public const string ProxyConnection = "Proxy-Connection";
        public const string Trailer = "Trailer";
        public const string TransferEncoding = "Transfer-Encoding";
        public const string Upgrade = "Upgrade";
        public const string Via = "Via";
        public const string Warning = "Warning";
        public const string ContentLength = "Content-Length";
        public const string ContentType = "Content-Type";
        public const string ContentDisposition = "Content-Disposition";
        public const string ContentEncoding = "Content-Encoding";
        public const string ContentLanguage = "Content-Language";
        public const string ContentLocation = "Content-Location";
        public const string ContentRange = "Content-Range";
        public const string Expires = "Expires";
        public const string LastModified = "Last-Modified";
        public const string Age = "Age";
        public const string Location = "Location";
        public const string ProxyAuthenticate = "Proxy-Authenticate";
        public const string RetryAfter = "Retry-After";
        public const string Server = "Server";
        public const string SetCookie = "Set-Cookie";
        public const string SetCookie2 = "Set-Cookie2";
        public const string Vary = "Vary";
        public const string WWWAuthenticate = "WWW-Authenticate";
        public const string Accept = "Accept";
        public const string AcceptCharset = "Accept-Charset";
        public const string AcceptEncoding = "Accept-Encoding";
        public const string AcceptLanguage = "Accept-Language";
        public const string Authorization = "Authorization";
        public const string Cookie = "Cookie";
        public const string Cookie2 = "Cookie2";
        public const string Expect = "Expect";
        public const string From = "From";
        public const string Host = "Host";
        public const string IfMatch = "If-Match";
        public const string IfModifiedSince = "If-Modified-Since";
        public const string IfNoneMatch = "If-None-Match";
        public const string IfRange = "If-Range";
        public const string IfUnmodifiedSince = "If-Unmodified-Since";
        public const string MaxForwards = "Max-Forwards";
        public const string ProxyAuthorization = "Proxy-Authorization";
        public const string Referer = "Referer";
        public const string Range = "Range";
        public const string UserAgent = "User-Agent";
        public const string ContentMD5 = "Content-MD5";
        public const string ETag = "ETag";
        public const string TE = "TE";
        public const string Allow = "Allow";
        public const string AcceptRanges = "Accept-Ranges";
        public const string P3P = "P3P";
        public const string XPoweredBy = "X-Powered-By";
        public const string XAspNetVersion = "X-AspNet-Version";
        public const string SecWebSocketKey = "Sec-WebSocket-Key";
        public const string SecWebSocketExtensions = "Sec-WebSocket-Extensions";
        public const string SecWebSocketAccept = "Sec-WebSocket-Accept";
        public const string Origin = "Origin";
        public const string SecWebSocketProtocol = "Sec-WebSocket-Protocol";
        public const string SecWebSocketVersion = "Sec-WebSocket-Version";
    }
}
