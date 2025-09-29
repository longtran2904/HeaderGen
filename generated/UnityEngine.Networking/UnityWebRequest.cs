#region UnityEngine.UnityWebRequestModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UnityWebRequestModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using UnityEngine.Bindings;

namespace UnityEngine.Networking
{
    [NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequest.h")]
    public class UnityWebRequest : IDisposable
    {
        public const string kHttpVerbGET = "GET";
        public const string kHttpVerbHEAD = "HEAD";
        public const string kHttpVerbPOST = "POST";
        public const string kHttpVerbPUT = "PUT";
        public const string kHttpVerbCREATE = "CREATE";
        public const string kHttpVerbDELETE = "DELETE";

        public UnityWebRequest();
        public UnityWebRequest(string url);
        public UnityWebRequest(Uri uri);
        public UnityWebRequest(string url, string method);
        public UnityWebRequest(Uri uri, string method);
        public UnityWebRequest(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler);
        public UnityWebRequest(Uri uri, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler);

        ~UnityWebRequest();

        public bool disposeCertificateHandlerOnDispose { get; set; }
        public bool disposeDownloadHandlerOnDispose { get; set; }
        public bool disposeUploadHandlerOnDispose { get; set; }
        public string method { get; set; }
        public string error { get; }
        public bool useHttpContinue { get; set; }
        public string url { get; set; }
        public Uri uri { get; set; }
        public long responseCode { get; }
        public float uploadProgress { get; }
        public bool isModifiable { get; }
        public bool isDone { get; }
        [Obsolete("UnityWebRequest.isNetworkError is deprecated. Use (UnityWebRequest.result == UnityWebRequest.Result.ConnectionError) instead.", False)]
        public bool isNetworkError { get; }
        [Obsolete("UnityWebRequest.isHttpError is deprecated. Use (UnityWebRequest.result == UnityWebRequest.Result.ProtocolError) instead.", False)]
        public bool isHttpError { get; }
        public Result result { get; }
        public float downloadProgress { get; }
        public ulong uploadedBytes { get; }
        public ulong downloadedBytes { get; }
        public int redirectLimit { get; set; }
        [Obsolete("HTTP/2 and many HTTP/1.1 servers don't support this; we recommend leaving it set to false (default).", False)]
        public bool chunkedTransfer { get; set; }
        public UploadHandler uploadHandler { get; set; }
        public DownloadHandler downloadHandler { get; set; }
        public CertificateHandler certificateHandler { get; set; }
        public int timeout { get; set; }
        [Obsolete("UnityWebRequest.isError has been renamed to isNetworkError for clarity. (UnityUpgradable) -> isNetworkError", False)]
        public bool isError { get; }

        public static void ClearCookieCache();
        public static void ClearCookieCache(Uri uri);
        public void Dispose();
        [Obsolete("Use SendWebRequest.  It returns a UnityWebRequestAsyncOperation which contains a reference to the WebRequest object.", False)]
        public AsyncOperation Send();
        public UnityWebRequestAsyncOperation SendWebRequest();
        [NativeMethod(IsThreadSafe = True)]
        public void Abort();
        public string GetRequestHeader(string name);
        public void SetRequestHeader(string name, string value);
        public string GetResponseHeader(string name);
        public Dictionary<string, string> GetResponseHeaders();
        public static UnityWebRequest Get(string uri);
        public static UnityWebRequest Get(Uri uri);
        public static UnityWebRequest Delete(string uri);
        public static UnityWebRequest Delete(Uri uri);
        public static UnityWebRequest Head(string uri);
        public static UnityWebRequest Head(Uri uri);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("UnityWebRequest.GetTexture is obsolete. Use UnityWebRequestTexture.GetTexture instead (UnityUpgradable) -> [UnityEngine] UnityWebRequestTexture.GetTexture(*)", True)]
        public static UnityWebRequest GetTexture(string uri);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("UnityWebRequest.GetTexture is obsolete. Use UnityWebRequestTexture.GetTexture instead (UnityUpgradable) -> [UnityEngine] UnityWebRequestTexture.GetTexture(*)", True)]
        public static UnityWebRequest GetTexture(string uri, bool nonReadable);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("UnityWebRequest.GetAudioClip is obsolete. Use UnityWebRequestMultimedia.GetAudioClip instead (UnityUpgradable) -> [UnityEngine] UnityWebRequestMultimedia.GetAudioClip(*)", True)]
        public static UnityWebRequest GetAudioClip(string uri, AudioType audioType);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("UnityWebRequest.GetAssetBundle is obsolete. Use UnityWebRequestAssetBundle.GetAssetBundle instead (UnityUpgradable) -> [UnityEngine] UnityWebRequestAssetBundle.GetAssetBundle(*)", True)]
        public static UnityWebRequest GetAssetBundle(string uri);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("UnityWebRequest.GetAssetBundle is obsolete. Use UnityWebRequestAssetBundle.GetAssetBundle instead (UnityUpgradable) -> [UnityEngine] UnityWebRequestAssetBundle.GetAssetBundle(*)", True)]
        public static UnityWebRequest GetAssetBundle(string uri, uint crc);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("UnityWebRequest.GetAssetBundle is obsolete. Use UnityWebRequestAssetBundle.GetAssetBundle instead (UnityUpgradable) -> [UnityEngine] UnityWebRequestAssetBundle.GetAssetBundle(*)", True)]
        public static UnityWebRequest GetAssetBundle(string uri, uint version, uint crc);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("UnityWebRequest.GetAssetBundle is obsolete. Use UnityWebRequestAssetBundle.GetAssetBundle instead (UnityUpgradable) -> [UnityEngine] UnityWebRequestAssetBundle.GetAssetBundle(*)", True)]
        public static UnityWebRequest GetAssetBundle(string uri, Hash128 hash, uint crc);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("UnityWebRequest.GetAssetBundle is obsolete. Use UnityWebRequestAssetBundle.GetAssetBundle instead (UnityUpgradable) -> [UnityEngine] UnityWebRequestAssetBundle.GetAssetBundle(*)", True)]
        public static UnityWebRequest GetAssetBundle(string uri, CachedAssetBundle cachedAssetBundle, uint crc);
        public static UnityWebRequest Put(string uri, byte[] bodyData);
        public static UnityWebRequest Put(Uri uri, byte[] bodyData);
        public static UnityWebRequest Put(string uri, string bodyData);
        public static UnityWebRequest Put(Uri uri, string bodyData);
        public static UnityWebRequest Post(string uri, string postData);
        public static UnityWebRequest Post(Uri uri, string postData);
        public static UnityWebRequest Post(string uri, WWWForm formData);
        public static UnityWebRequest Post(Uri uri, WWWForm formData);
        public static UnityWebRequest Post(string uri, List<IMultipartFormSection> multipartFormSections);
        public static UnityWebRequest Post(Uri uri, List<IMultipartFormSection> multipartFormSections);
        public static UnityWebRequest Post(string uri, List<IMultipartFormSection> multipartFormSections, byte[] boundary);
        public static UnityWebRequest Post(Uri uri, List<IMultipartFormSection> multipartFormSections, byte[] boundary);
        public static UnityWebRequest Post(string uri, Dictionary<string, string> formFields);
        public static UnityWebRequest Post(Uri uri, Dictionary<string, string> formFields);
        public static string EscapeURL(string s);
        public static string EscapeURL(string s, Encoding e);
        public static string UnEscapeURL(string s);
        public static string UnEscapeURL(string s, Encoding e);
        public static byte[] SerializeFormSections(List<IMultipartFormSection> multipartFormSections, byte[] boundary);
        public static byte[] GenerateBoundary();
        public static byte[] SerializeSimpleForm(Dictionary<string, string> formFields);

        public enum Result
        {
            InProgress = 0,
            Success = 1,
            ConnectionError = 2,
            ProtocolError = 3,
            DataProcessingError = 4
        }
    }
}
