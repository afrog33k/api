﻿#pragma warning disable 1717
namespace Javax.Net.Ssl
{
		/// <java-name>
		/// javax/net/ssl/SSLPeerUnverifiedException
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLPeerUnverifiedException", AccessFlags = 33)]
		public partial class SSLPeerUnverifiedException : global::Javax.Net.Ssl.SSLException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SSLPeerUnverifiedException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SSLPeerUnverifiedException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// javax/net/ssl/CertPathTrustManagerParameters
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/CertPathTrustManagerParameters", AccessFlags = 33)]
		public partial class CertPathTrustManagerParameters : global::Javax.Net.Ssl.IManagerFactoryParameters
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/security/cert/CertPathParameters;)V", AccessFlags = 1)]
				public CertPathTrustManagerParameters(global::Java.Security.Cert.ICertPathParameters certPathParameters) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getParameters
				/// </java-name>
				[Dot42.DexImport("getParameters", "()Ljava/security/cert/CertPathParameters;", AccessFlags = 1)]
				public virtual global::Java.Security.Cert.ICertPathParameters GetParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.ICertPathParameters);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CertPathTrustManagerParameters() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getParameters
				/// </java-name>
				public global::Java.Security.Cert.ICertPathParameters Parameters
				{
				[Dot42.DexImport("getParameters", "()Ljava/security/cert/CertPathParameters;", AccessFlags = 1)]
						get{ return GetParameters(); }
				}

		}

		/// <java-name>
		/// javax/net/ssl/SSLKeyException
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLKeyException", AccessFlags = 33)]
		public partial class SSLKeyException : global::Javax.Net.Ssl.SSLException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SSLKeyException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SSLKeyException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// javax/net/ssl/SSLProtocolException
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLProtocolException", AccessFlags = 33)]
		public partial class SSLProtocolException : global::Javax.Net.Ssl.SSLException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SSLProtocolException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SSLProtocolException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// javax/net/ssl/SSLServerSocketFactory
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLServerSocketFactory", AccessFlags = 1057)]
		public abstract partial class SSLServerSocketFactory : global::Javax.Net.ServerSocketFactory
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal SSLServerSocketFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDefault
				/// </java-name>
				[Dot42.DexImport("getDefault", "()Ljavax/net/ServerSocketFactory;", AccessFlags = 41)]
				public static global::Javax.Net.ServerSocketFactory GetDefault() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.ServerSocketFactory);
				}

				/// <java-name>
				/// getDefaultCipherSuites
				/// </java-name>
				[Dot42.DexImport("getDefaultCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetDefaultCipherSuites() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSupportedCipherSuites
				/// </java-name>
				[Dot42.DexImport("getSupportedCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetSupportedCipherSuites() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDefault
				/// </java-name>
				public static global::Javax.Net.ServerSocketFactory Default
				{
				[Dot42.DexImport("getDefault", "()Ljavax/net/ServerSocketFactory;", AccessFlags = 41)]
						get{ return GetDefault(); }
				}

				/// <java-name>
				/// getDefaultCipherSuites
				/// </java-name>
				public string[] DefaultCipherSuites
				{
				[Dot42.DexImport("getDefaultCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetDefaultCipherSuites(); }
				}

				/// <java-name>
				/// getSupportedCipherSuites
				/// </java-name>
				public string[] SupportedCipherSuites
				{
				[Dot42.DexImport("getSupportedCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetSupportedCipherSuites(); }
				}

		}

		/// <java-name>
		/// javax/net/ssl/HandshakeCompletedEvent
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/HandshakeCompletedEvent", AccessFlags = 33)]
		public partial class HandshakeCompletedEvent : global::Java.Util.EventObject
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljavax/net/ssl/SSLSocket;Ljavax/net/ssl/SSLSession;)V", AccessFlags = 1)]
				public HandshakeCompletedEvent(global::Javax.Net.Ssl.SSLSocket sSLSocket, global::Javax.Net.Ssl.ISSLSession sSLSession) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSession
				/// </java-name>
				[Dot42.DexImport("getSession", "()Ljavax/net/ssl/SSLSession;", AccessFlags = 1)]
				public virtual global::Javax.Net.Ssl.ISSLSession GetSession() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.ISSLSession);
				}

				/// <java-name>
				/// getCipherSuite
				/// </java-name>
				[Dot42.DexImport("getCipherSuite", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetCipherSuite() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getLocalCertificates
				/// </java-name>
				[Dot42.DexImport("getLocalCertificates", "()[Ljava/security/cert/Certificate;", AccessFlags = 1)]
				public virtual global::Java.Security.Cert.Certificate[] GetLocalCertificates() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.Certificate[]);
				}

				/// <java-name>
				/// getPeerCertificates
				/// </java-name>
				[Dot42.DexImport("getPeerCertificates", "()[Ljava/security/cert/Certificate;", AccessFlags = 1)]
				public virtual global::Java.Security.Cert.Certificate[] GetPeerCertificates() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.Certificate[]);
				}

				/// <java-name>
				/// getPeerCertificateChain
				/// </java-name>
				[Dot42.DexImport("getPeerCertificateChain", "()[Ljavax/security/cert/X509Certificate;", AccessFlags = 1)]
				public virtual global::Javax.Security.Cert.X509Certificate[] GetPeerCertificateChain() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Security.Cert.X509Certificate[]);
				}

				/// <java-name>
				/// getPeerPrincipal
				/// </java-name>
				[Dot42.DexImport("getPeerPrincipal", "()Ljava/security/Principal;", AccessFlags = 1)]
				public virtual global::Java.Security.IPrincipal GetPeerPrincipal() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IPrincipal);
				}

				/// <java-name>
				/// getLocalPrincipal
				/// </java-name>
				[Dot42.DexImport("getLocalPrincipal", "()Ljava/security/Principal;", AccessFlags = 1)]
				public virtual global::Java.Security.IPrincipal GetLocalPrincipal() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IPrincipal);
				}

				/// <java-name>
				/// getSocket
				/// </java-name>
				[Dot42.DexImport("getSocket", "()Ljavax/net/ssl/SSLSocket;", AccessFlags = 1)]
				public virtual global::Javax.Net.Ssl.SSLSocket GetSocket() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLSocket);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HandshakeCompletedEvent() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSession
				/// </java-name>
				public global::Javax.Net.Ssl.ISSLSession Session
				{
				[Dot42.DexImport("getSession", "()Ljavax/net/ssl/SSLSession;", AccessFlags = 1)]
						get{ return GetSession(); }
				}

				/// <java-name>
				/// getCipherSuite
				/// </java-name>
				public string CipherSuite
				{
				[Dot42.DexImport("getCipherSuite", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetCipherSuite(); }
				}

				/// <java-name>
				/// getLocalCertificates
				/// </java-name>
				public global::Java.Security.Cert.Certificate[] LocalCertificates
				{
				[Dot42.DexImport("getLocalCertificates", "()[Ljava/security/cert/Certificate;", AccessFlags = 1)]
						get{ return GetLocalCertificates(); }
				}

				/// <java-name>
				/// getPeerCertificates
				/// </java-name>
				public global::Java.Security.Cert.Certificate[] PeerCertificates
				{
				[Dot42.DexImport("getPeerCertificates", "()[Ljava/security/cert/Certificate;", AccessFlags = 1)]
						get{ return GetPeerCertificates(); }
				}

				/// <java-name>
				/// getPeerCertificateChain
				/// </java-name>
				public global::Javax.Security.Cert.X509Certificate[] PeerCertificateChain
				{
				[Dot42.DexImport("getPeerCertificateChain", "()[Ljavax/security/cert/X509Certificate;", AccessFlags = 1)]
						get{ return GetPeerCertificateChain(); }
				}

				/// <java-name>
				/// getPeerPrincipal
				/// </java-name>
				public global::Java.Security.IPrincipal PeerPrincipal
				{
				[Dot42.DexImport("getPeerPrincipal", "()Ljava/security/Principal;", AccessFlags = 1)]
						get{ return GetPeerPrincipal(); }
				}

				/// <java-name>
				/// getLocalPrincipal
				/// </java-name>
				public global::Java.Security.IPrincipal LocalPrincipal
				{
				[Dot42.DexImport("getLocalPrincipal", "()Ljava/security/Principal;", AccessFlags = 1)]
						get{ return GetLocalPrincipal(); }
				}

				/// <java-name>
				/// getSocket
				/// </java-name>
				public global::Javax.Net.Ssl.SSLSocket Socket
				{
				[Dot42.DexImport("getSocket", "()Ljavax/net/ssl/SSLSocket;", AccessFlags = 1)]
						get{ return GetSocket(); }
				}

		}

		/// <java-name>
		/// javax/net/ssl/SSLSessionBindingEvent
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLSessionBindingEvent", AccessFlags = 33)]
		public partial class SSLSessionBindingEvent : global::Java.Util.EventObject
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljavax/net/ssl/SSLSession;Ljava/lang/String;)V", AccessFlags = 1)]
				public SSLSessionBindingEvent(global::Javax.Net.Ssl.ISSLSession sSLSession, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getSession
				/// </java-name>
				[Dot42.DexImport("getSession", "()Ljavax/net/ssl/SSLSession;", AccessFlags = 1)]
				public virtual global::Javax.Net.Ssl.ISSLSession GetSession() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.ISSLSession);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SSLSessionBindingEvent() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <java-name>
				/// getSession
				/// </java-name>
				public global::Javax.Net.Ssl.ISSLSession Session
				{
				[Dot42.DexImport("getSession", "()Ljavax/net/ssl/SSLSession;", AccessFlags = 1)]
						get{ return GetSession(); }
				}

		}

		/// <java-name>
		/// javax/net/ssl/TrustManagerFactorySpi
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/TrustManagerFactorySpi", AccessFlags = 1057)]
		public abstract partial class TrustManagerFactorySpi
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TrustManagerFactorySpi() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(Ljava/security/KeyStore;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(global::Java.Security.KeyStore keyStore) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(Ljavax/net/ssl/ManagerFactoryParameters;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(global::Javax.Net.Ssl.IManagerFactoryParameters managerFactoryParameters) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGetTrustManagers
				/// </java-name>
				[Dot42.DexImport("engineGetTrustManagers", "()[Ljavax/net/ssl/TrustManager;", AccessFlags = 1028)]
				protected internal abstract global::Javax.Net.Ssl.ITrustManager[] EngineGetTrustManagers() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/net/ssl/SSLEngineResult
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLEngineResult", AccessFlags = 33)]
		public partial class SSLEngineResult
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljavax/net/ssl/SSLEngineResult$Status;Ljavax/net/ssl/SSLEngineResult$HandshakeSt" +
    "atus;II)V", AccessFlags = 1)]
				public SSLEngineResult(global::Javax.Net.Ssl.SSLEngineResult.Status status, global::Javax.Net.Ssl.SSLEngineResult.HandshakeStatus handshakeStatus, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getStatus
				/// </java-name>
				[Dot42.DexImport("getStatus", "()Ljavax/net/ssl/SSLEngineResult$Status;", AccessFlags = 17)]
				public global::Javax.Net.Ssl.SSLEngineResult.Status GetStatus() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLEngineResult.Status);
				}

				/// <java-name>
				/// getHandshakeStatus
				/// </java-name>
				[Dot42.DexImport("getHandshakeStatus", "()Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", AccessFlags = 17)]
				public global::Javax.Net.Ssl.SSLEngineResult.HandshakeStatus GetHandshakeStatus() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLEngineResult.HandshakeStatus);
				}

				/// <java-name>
				/// bytesConsumed
				/// </java-name>
				[Dot42.DexImport("bytesConsumed", "()I", AccessFlags = 17)]
				public int BytesConsumed() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// bytesProduced
				/// </java-name>
				[Dot42.DexImport("bytesProduced", "()I", AccessFlags = 17)]
				public int BytesProduced() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SSLEngineResult() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// javax/net/ssl/SSLEngineResult$Status
				/// </java-name>
				[Dot42.DexImport("javax/net/ssl/SSLEngineResult$Status", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Ljavax/net/ssl/SSLEngineResult$Status;>;")]
				public sealed class Status
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// BUFFER_OVERFLOW
						/// </java-name>
						[Dot42.DexImport("BUFFER_OVERFLOW", "Ljavax/net/ssl/SSLEngineResult$Status;", AccessFlags = 16409)]
						public static readonly Status BUFFER_OVERFLOW;
						/// <java-name>
						/// BUFFER_UNDERFLOW
						/// </java-name>
						[Dot42.DexImport("BUFFER_UNDERFLOW", "Ljavax/net/ssl/SSLEngineResult$Status;", AccessFlags = 16409)]
						public static readonly Status BUFFER_UNDERFLOW;
						/// <java-name>
						/// CLOSED
						/// </java-name>
						[Dot42.DexImport("CLOSED", "Ljavax/net/ssl/SSLEngineResult$Status;", AccessFlags = 16409)]
						public static readonly Status CLOSED;
						/// <java-name>
						/// OK
						/// </java-name>
						[Dot42.DexImport("OK", "Ljavax/net/ssl/SSLEngineResult$Status;", AccessFlags = 16409)]
						public static readonly Status OK;
						private Status() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Ljavax/net/ssl/SSLEngineResult$Status;", AccessFlags = 9)]
						public static Status[] Values() /* MethodBuilder.Create */ 
						{
								return default(Status[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljavax/net/ssl/SSLEngineResult$Status;", AccessFlags = 9)]
						public static Status ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(Status);
						}

				}

				/// <java-name>
				/// javax/net/ssl/SSLEngineResult$HandshakeStatus
				/// </java-name>
				[Dot42.DexImport("javax/net/ssl/SSLEngineResult$HandshakeStatus", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;>;")]
				public sealed class HandshakeStatus
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// FINISHED
						/// </java-name>
						[Dot42.DexImport("FINISHED", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", AccessFlags = 16409)]
						public static readonly HandshakeStatus FINISHED;
						/// <java-name>
						/// NEED_TASK
						/// </java-name>
						[Dot42.DexImport("NEED_TASK", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", AccessFlags = 16409)]
						public static readonly HandshakeStatus NEED_TASK;
						/// <java-name>
						/// NEED_UNWRAP
						/// </java-name>
						[Dot42.DexImport("NEED_UNWRAP", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", AccessFlags = 16409)]
						public static readonly HandshakeStatus NEED_UNWRAP;
						/// <java-name>
						/// NEED_WRAP
						/// </java-name>
						[Dot42.DexImport("NEED_WRAP", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", AccessFlags = 16409)]
						public static readonly HandshakeStatus NEED_WRAP;
						/// <java-name>
						/// NOT_HANDSHAKING
						/// </java-name>
						[Dot42.DexImport("NOT_HANDSHAKING", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", AccessFlags = 16409)]
						public static readonly HandshakeStatus NOT_HANDSHAKING;
						private HandshakeStatus() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", AccessFlags = 9)]
						public static HandshakeStatus[] Values() /* MethodBuilder.Create */ 
						{
								return default(HandshakeStatus[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", AccessFlags = 9)]
						public static HandshakeStatus ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(HandshakeStatus);
						}

				}

		}

		/// <java-name>
		/// javax/net/ssl/SSLSessionContext
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLSessionContext", AccessFlags = 1537)]
		public partial interface ISSLSessionContext
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getIds
				/// </java-name>
				[Dot42.DexImport("getIds", "()Ljava/util/Enumeration;", AccessFlags = 1025, Signature = "()Ljava/util/Enumeration<[B>;")]
				global::Java.Util.IEnumeration<sbyte[]> GetIds() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSession
				/// </java-name>
				[Dot42.DexImport("getSession", "([B)Ljavax/net/ssl/SSLSession;", AccessFlags = 1025)]
				global::Javax.Net.Ssl.ISSLSession GetSession(sbyte[] sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSessionCacheSize
				/// </java-name>
				[Dot42.DexImport("getSessionCacheSize", "()I", AccessFlags = 1025)]
				int GetSessionCacheSize() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSessionTimeout
				/// </java-name>
				[Dot42.DexImport("getSessionTimeout", "()I", AccessFlags = 1025)]
				int GetSessionTimeout() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setSessionCacheSize
				/// </java-name>
				[Dot42.DexImport("setSessionCacheSize", "(I)V", AccessFlags = 1025)]
				void SetSessionCacheSize(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setSessionTimeout
				/// </java-name>
				[Dot42.DexImport("setSessionTimeout", "(I)V", AccessFlags = 1025)]
				void SetSessionTimeout(int int32) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/net/ssl/X509ExtendedKeyManager
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/X509ExtendedKeyManager", AccessFlags = 1057)]
		public abstract partial class X509ExtendedKeyManager : global::Javax.Net.Ssl.IX509KeyManager
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal X509ExtendedKeyManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// chooseEngineClientAlias
				/// </java-name>
				[Dot42.DexImport("chooseEngineClientAlias", "([Ljava/lang/String;[Ljava/security/Principal;Ljavax/net/ssl/SSLEngine;)Ljava/lan" +
    "g/String;", AccessFlags = 1)]
				public virtual string ChooseEngineClientAlias(string[] @string, global::Java.Security.IPrincipal[] principal, global::Javax.Net.Ssl.SSLEngine sSLEngine) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// chooseEngineServerAlias
				/// </java-name>
				[Dot42.DexImport("chooseEngineServerAlias", "(Ljava/lang/String;[Ljava/security/Principal;Ljavax/net/ssl/SSLEngine;)Ljava/lang" +
    "/String;", AccessFlags = 1)]
				public virtual string ChooseEngineServerAlias(string @string, global::Java.Security.IPrincipal[] principal, global::Javax.Net.Ssl.SSLEngine sSLEngine) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[Dot42.DexImport("javax/net/ssl/X509KeyManager", "chooseClientAlias", "([Ljava/lang/String;[Ljava/security/Principal;Ljava/net/Socket;)Ljava/lang/String" +
    ";", AccessFlags = 1025)]
				public virtual string ChooseClientAlias(string[] @string, global::Java.Security.IPrincipal[] principal, global::Java.Net.Socket socket) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("javax/net/ssl/X509KeyManager", "chooseServerAlias", "(Ljava/lang/String;[Ljava/security/Principal;Ljava/net/Socket;)Ljava/lang/String;" +
    "", AccessFlags = 1025)]
				public virtual string ChooseServerAlias(string @string, global::Java.Security.IPrincipal[] principal, global::Java.Net.Socket socket) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("javax/net/ssl/X509KeyManager", "getCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/X509Certificate;", AccessFlags = 1025)]
				public virtual global::Java.Security.Cert.X509Certificate[] GetCertificateChain(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Security.Cert.X509Certificate[]);
				}

				[Dot42.DexImport("javax/net/ssl/X509KeyManager", "getClientAliases", "(Ljava/lang/String;[Ljava/security/Principal;)[Ljava/lang/String;", AccessFlags = 1025)]
				public virtual string[] GetClientAliases(string @string, global::Java.Security.IPrincipal[] principal) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string[]);
				}

				[Dot42.DexImport("javax/net/ssl/X509KeyManager", "getServerAliases", "(Ljava/lang/String;[Ljava/security/Principal;)[Ljava/lang/String;", AccessFlags = 1025)]
				public virtual string[] GetServerAliases(string @string, global::Java.Security.IPrincipal[] principal) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string[]);
				}

				[Dot42.DexImport("javax/net/ssl/X509KeyManager", "getPrivateKey", "(Ljava/lang/String;)Ljava/security/PrivateKey;", AccessFlags = 1025)]
				public virtual global::Java.Security.IPrivateKey GetPrivateKey(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Security.IPrivateKey);
				}

		}

		/// <java-name>
		/// javax/net/ssl/HostnameVerifier
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/HostnameVerifier", AccessFlags = 1537)]
		public partial interface IHostnameVerifier
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "(Ljava/lang/String;Ljavax/net/ssl/SSLSession;)Z", AccessFlags = 1025)]
				bool Verify(string @string, global::Javax.Net.Ssl.ISSLSession sSLSession) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/net/ssl/KeyManager
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/KeyManager", AccessFlags = 1537)]
		public partial interface IKeyManager
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// javax/net/ssl/SSLParameters
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLParameters", AccessFlags = 33)]
		public partial class SSLParameters
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SSLParameters() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([Ljava/lang/String;)V", AccessFlags = 1)]
				public SSLParameters(string[] @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([Ljava/lang/String;[Ljava/lang/String;)V", AccessFlags = 1)]
				public SSLParameters(string[] @string, string[] string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCipherSuites
				/// </java-name>
				[Dot42.DexImport("getCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] GetCipherSuites() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// setCipherSuites
				/// </java-name>
				[Dot42.DexImport("setCipherSuites", "([Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetCipherSuites(string[] @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getProtocols
				/// </java-name>
				[Dot42.DexImport("getProtocols", "()[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] GetProtocols() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// setProtocols
				/// </java-name>
				[Dot42.DexImport("setProtocols", "([Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetProtocols(string[] @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getNeedClientAuth
				/// </java-name>
				[Dot42.DexImport("getNeedClientAuth", "()Z", AccessFlags = 1)]
				public virtual bool GetNeedClientAuth() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setNeedClientAuth
				/// </java-name>
				[Dot42.DexImport("setNeedClientAuth", "(Z)V", AccessFlags = 1)]
				public virtual void SetNeedClientAuth(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getWantClientAuth
				/// </java-name>
				[Dot42.DexImport("getWantClientAuth", "()Z", AccessFlags = 1)]
				public virtual bool GetWantClientAuth() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setWantClientAuth
				/// </java-name>
				[Dot42.DexImport("setWantClientAuth", "(Z)V", AccessFlags = 1)]
				public virtual void SetWantClientAuth(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCipherSuites
				/// </java-name>
				public string[] CipherSuites
				{
				[Dot42.DexImport("getCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetCipherSuites(); }
				[Dot42.DexImport("setCipherSuites", "([Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetCipherSuites(value); }
				}

				/// <java-name>
				/// getProtocols
				/// </java-name>
				public string[] Protocols
				{
				[Dot42.DexImport("getProtocols", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetProtocols(); }
				[Dot42.DexImport("setProtocols", "([Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetProtocols(value); }
				}

				/// <java-name>
				/// getNeedClientAuth
				/// </java-name>
				public bool IsNeedClientAuth
				{
				[Dot42.DexImport("getNeedClientAuth", "()Z", AccessFlags = 1)]
						get{ return GetNeedClientAuth(); }
				[Dot42.DexImport("setNeedClientAuth", "(Z)V", AccessFlags = 1)]
						set{ SetNeedClientAuth(value); }
				}

				/// <java-name>
				/// getWantClientAuth
				/// </java-name>
				public bool IsWantClientAuth
				{
				[Dot42.DexImport("getWantClientAuth", "()Z", AccessFlags = 1)]
						get{ return GetWantClientAuth(); }
				[Dot42.DexImport("setWantClientAuth", "(Z)V", AccessFlags = 1)]
						set{ SetWantClientAuth(value); }
				}

		}

		/// <java-name>
		/// javax/net/ssl/SSLHandshakeException
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLHandshakeException", AccessFlags = 33)]
		public partial class SSLHandshakeException : global::Javax.Net.Ssl.SSLException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SSLHandshakeException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SSLHandshakeException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// javax/net/ssl/SSLContextSpi
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLContextSpi", AccessFlags = 1057)]
		public abstract partial class SSLContextSpi
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SSLContextSpi() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "([Ljavax/net/ssl/KeyManager;[Ljavax/net/ssl/TrustManager;Ljava/security/SecureRan" +
    "dom;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(global::Javax.Net.Ssl.IKeyManager[] keyManager, global::Javax.Net.Ssl.ITrustManager[] trustManager, global::Java.Security.SecureRandom secureRandom) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGetSocketFactory
				/// </java-name>
				[Dot42.DexImport("engineGetSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;", AccessFlags = 1028)]
				protected internal abstract global::Javax.Net.Ssl.SSLSocketFactory EngineGetSocketFactory() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGetServerSocketFactory
				/// </java-name>
				[Dot42.DexImport("engineGetServerSocketFactory", "()Ljavax/net/ssl/SSLServerSocketFactory;", AccessFlags = 1028)]
				protected internal abstract global::Javax.Net.Ssl.SSLServerSocketFactory EngineGetServerSocketFactory() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineCreateSSLEngine
				/// </java-name>
				[Dot42.DexImport("engineCreateSSLEngine", "(Ljava/lang/String;I)Ljavax/net/ssl/SSLEngine;", AccessFlags = 1028)]
				protected internal abstract global::Javax.Net.Ssl.SSLEngine EngineCreateSSLEngine(string @string, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineCreateSSLEngine
				/// </java-name>
				[Dot42.DexImport("engineCreateSSLEngine", "()Ljavax/net/ssl/SSLEngine;", AccessFlags = 1028)]
				protected internal abstract global::Javax.Net.Ssl.SSLEngine EngineCreateSSLEngine() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGetServerSessionContext
				/// </java-name>
				[Dot42.DexImport("engineGetServerSessionContext", "()Ljavax/net/ssl/SSLSessionContext;", AccessFlags = 1028)]
				protected internal abstract global::Javax.Net.Ssl.ISSLSessionContext EngineGetServerSessionContext() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGetClientSessionContext
				/// </java-name>
				[Dot42.DexImport("engineGetClientSessionContext", "()Ljavax/net/ssl/SSLSessionContext;", AccessFlags = 1028)]
				protected internal abstract global::Javax.Net.Ssl.ISSLSessionContext EngineGetClientSessionContext() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGetDefaultSSLParameters
				/// </java-name>
				[Dot42.DexImport("engineGetDefaultSSLParameters", "()Ljavax/net/ssl/SSLParameters;", AccessFlags = 4)]
				protected internal virtual global::Javax.Net.Ssl.SSLParameters EngineGetDefaultSSLParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLParameters);
				}

				/// <java-name>
				/// engineGetSupportedSSLParameters
				/// </java-name>
				[Dot42.DexImport("engineGetSupportedSSLParameters", "()Ljavax/net/ssl/SSLParameters;", AccessFlags = 4)]
				protected internal virtual global::Javax.Net.Ssl.SSLParameters EngineGetSupportedSSLParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLParameters);
				}

		}

		/// <java-name>
		/// javax/net/ssl/SSLSessionBindingListener
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLSessionBindingListener", AccessFlags = 1537)]
		public partial interface ISSLSessionBindingListener : global::Java.Util.IEventListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// valueBound
				/// </java-name>
				[Dot42.DexImport("valueBound", "(Ljavax/net/ssl/SSLSessionBindingEvent;)V", AccessFlags = 1025)]
				void ValueBound(global::Javax.Net.Ssl.SSLSessionBindingEvent sSLSessionBindingEvent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// valueUnbound
				/// </java-name>
				[Dot42.DexImport("valueUnbound", "(Ljavax/net/ssl/SSLSessionBindingEvent;)V", AccessFlags = 1025)]
				void ValueUnbound(global::Javax.Net.Ssl.SSLSessionBindingEvent sSLSessionBindingEvent) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/net/ssl/SSLSocket
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLSocket", AccessFlags = 1057)]
		public abstract partial class SSLSocket : global::Java.Net.Socket
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal SSLSocket() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 4)]
				protected internal SSLSocket(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/net/InetAddress;I)V", AccessFlags = 4)]
				protected internal SSLSocket(global::Java.Net.InetAddress inetAddress, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;ILjava/net/InetAddress;I)V", AccessFlags = 4)]
				protected internal SSLSocket(string @string, int int32, global::Java.Net.InetAddress inetAddress, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)V", AccessFlags = 4)]
				protected internal SSLSocket(global::Java.Net.InetAddress inetAddress, int int32, global::Java.Net.InetAddress inetAddress1, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// shutdownInput
				/// </java-name>
				[Dot42.DexImport("shutdownInput", "()V", AccessFlags = 1)]
				public override void ShutdownInput() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// shutdownOutput
				/// </java-name>
				[Dot42.DexImport("shutdownOutput", "()V", AccessFlags = 1)]
				public override void ShutdownOutput() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSupportedCipherSuites
				/// </java-name>
				[Dot42.DexImport("getSupportedCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetSupportedCipherSuites() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getEnabledCipherSuites
				/// </java-name>
				[Dot42.DexImport("getEnabledCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetEnabledCipherSuites() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setEnabledCipherSuites
				/// </java-name>
				[Dot42.DexImport("setEnabledCipherSuites", "([Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void SetEnabledCipherSuites(string[] @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSupportedProtocols
				/// </java-name>
				[Dot42.DexImport("getSupportedProtocols", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetSupportedProtocols() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getEnabledProtocols
				/// </java-name>
				[Dot42.DexImport("getEnabledProtocols", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetEnabledProtocols() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setEnabledProtocols
				/// </java-name>
				[Dot42.DexImport("setEnabledProtocols", "([Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void SetEnabledProtocols(string[] @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSession
				/// </java-name>
				[Dot42.DexImport("getSession", "()Ljavax/net/ssl/SSLSession;", AccessFlags = 1025)]
				public abstract global::Javax.Net.Ssl.ISSLSession GetSession() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addHandshakeCompletedListener
				/// </java-name>
				[Dot42.DexImport("addHandshakeCompletedListener", "(Ljavax/net/ssl/HandshakeCompletedListener;)V", AccessFlags = 1025)]
				public abstract void AddHandshakeCompletedListener(global::Javax.Net.Ssl.IHandshakeCompletedListener handshakeCompletedListener) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeHandshakeCompletedListener
				/// </java-name>
				[Dot42.DexImport("removeHandshakeCompletedListener", "(Ljavax/net/ssl/HandshakeCompletedListener;)V", AccessFlags = 1025)]
				public abstract void RemoveHandshakeCompletedListener(global::Javax.Net.Ssl.IHandshakeCompletedListener handshakeCompletedListener) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// startHandshake
				/// </java-name>
				[Dot42.DexImport("startHandshake", "()V", AccessFlags = 1025)]
				public abstract void StartHandshake() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setUseClientMode
				/// </java-name>
				[Dot42.DexImport("setUseClientMode", "(Z)V", AccessFlags = 1025)]
				public abstract void SetUseClientMode(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getUseClientMode
				/// </java-name>
				[Dot42.DexImport("getUseClientMode", "()Z", AccessFlags = 1025)]
				public abstract bool GetUseClientMode() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNeedClientAuth
				/// </java-name>
				[Dot42.DexImport("setNeedClientAuth", "(Z)V", AccessFlags = 1025)]
				public abstract void SetNeedClientAuth(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setWantClientAuth
				/// </java-name>
				[Dot42.DexImport("setWantClientAuth", "(Z)V", AccessFlags = 1025)]
				public abstract void SetWantClientAuth(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getNeedClientAuth
				/// </java-name>
				[Dot42.DexImport("getNeedClientAuth", "()Z", AccessFlags = 1025)]
				public abstract bool GetNeedClientAuth() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getWantClientAuth
				/// </java-name>
				[Dot42.DexImport("getWantClientAuth", "()Z", AccessFlags = 1025)]
				public abstract bool GetWantClientAuth() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setEnableSessionCreation
				/// </java-name>
				[Dot42.DexImport("setEnableSessionCreation", "(Z)V", AccessFlags = 1025)]
				public abstract void SetEnableSessionCreation(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getEnableSessionCreation
				/// </java-name>
				[Dot42.DexImport("getEnableSessionCreation", "()Z", AccessFlags = 1025)]
				public abstract bool GetEnableSessionCreation() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSSLParameters
				/// </java-name>
				[Dot42.DexImport("getSSLParameters", "()Ljavax/net/ssl/SSLParameters;", AccessFlags = 1)]
				public virtual global::Javax.Net.Ssl.SSLParameters GetSSLParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLParameters);
				}

				/// <java-name>
				/// setSSLParameters
				/// </java-name>
				[Dot42.DexImport("setSSLParameters", "(Ljavax/net/ssl/SSLParameters;)V", AccessFlags = 1)]
				public virtual void SetSSLParameters(global::Javax.Net.Ssl.SSLParameters sSLParameters) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSupportedCipherSuites
				/// </java-name>
				public string[] SupportedCipherSuites
				{
				[Dot42.DexImport("getSupportedCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetSupportedCipherSuites(); }
				}

				/// <java-name>
				/// getEnabledCipherSuites
				/// </java-name>
				public string[] EnabledCipherSuites
				{
				[Dot42.DexImport("getEnabledCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetEnabledCipherSuites(); }
				[Dot42.DexImport("setEnabledCipherSuites", "([Ljava/lang/String;)V", AccessFlags = 1025)]
						set{ SetEnabledCipherSuites(value); }
				}

				/// <java-name>
				/// getSupportedProtocols
				/// </java-name>
				public string[] SupportedProtocols
				{
				[Dot42.DexImport("getSupportedProtocols", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetSupportedProtocols(); }
				}

				/// <java-name>
				/// getEnabledProtocols
				/// </java-name>
				public string[] EnabledProtocols
				{
				[Dot42.DexImport("getEnabledProtocols", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetEnabledProtocols(); }
				[Dot42.DexImport("setEnabledProtocols", "([Ljava/lang/String;)V", AccessFlags = 1025)]
						set{ SetEnabledProtocols(value); }
				}

				/// <java-name>
				/// getSession
				/// </java-name>
				public global::Javax.Net.Ssl.ISSLSession Session
				{
				[Dot42.DexImport("getSession", "()Ljavax/net/ssl/SSLSession;", AccessFlags = 1025)]
						get{ return GetSession(); }
				}

				/// <java-name>
				/// getUseClientMode
				/// </java-name>
				public bool IsUseClientMode
				{
				[Dot42.DexImport("getUseClientMode", "()Z", AccessFlags = 1025)]
						get{ return GetUseClientMode(); }
				[Dot42.DexImport("setUseClientMode", "(Z)V", AccessFlags = 1025)]
						set{ SetUseClientMode(value); }
				}

				/// <java-name>
				/// getNeedClientAuth
				/// </java-name>
				public bool IsNeedClientAuth
				{
				[Dot42.DexImport("getNeedClientAuth", "()Z", AccessFlags = 1025)]
						get{ return GetNeedClientAuth(); }
				[Dot42.DexImport("setNeedClientAuth", "(Z)V", AccessFlags = 1025)]
						set{ SetNeedClientAuth(value); }
				}

				/// <java-name>
				/// getWantClientAuth
				/// </java-name>
				public bool IsWantClientAuth
				{
				[Dot42.DexImport("getWantClientAuth", "()Z", AccessFlags = 1025)]
						get{ return GetWantClientAuth(); }
				[Dot42.DexImport("setWantClientAuth", "(Z)V", AccessFlags = 1025)]
						set{ SetWantClientAuth(value); }
				}

				/// <java-name>
				/// getEnableSessionCreation
				/// </java-name>
				public bool IsEnableSessionCreation
				{
				[Dot42.DexImport("getEnableSessionCreation", "()Z", AccessFlags = 1025)]
						get{ return GetEnableSessionCreation(); }
				[Dot42.DexImport("setEnableSessionCreation", "(Z)V", AccessFlags = 1025)]
						set{ SetEnableSessionCreation(value); }
				}

				/// <java-name>
				/// getSSLParameters
				/// </java-name>
				public global::Javax.Net.Ssl.SSLParameters SSLParameters
				{
				[Dot42.DexImport("getSSLParameters", "()Ljavax/net/ssl/SSLParameters;", AccessFlags = 1)]
						get{ return GetSSLParameters(); }
				[Dot42.DexImport("setSSLParameters", "(Ljavax/net/ssl/SSLParameters;)V", AccessFlags = 1)]
						set{ SetSSLParameters(value); }
				}

		}

		/// <java-name>
		/// javax/net/ssl/SSLSession
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLSession", AccessFlags = 1537)]
		public partial interface ISSLSession
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getApplicationBufferSize
				/// </java-name>
				[Dot42.DexImport("getApplicationBufferSize", "()I", AccessFlags = 1025)]
				int GetApplicationBufferSize() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCipherSuite
				/// </java-name>
				[Dot42.DexImport("getCipherSuite", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetCipherSuite() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCreationTime
				/// </java-name>
				[Dot42.DexImport("getCreationTime", "()J", AccessFlags = 1025)]
				long GetCreationTime() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getId
				/// </java-name>
				[Dot42.DexImport("getId", "()[B", AccessFlags = 1025, IgnoreFromJava = true)]
				byte[] GetId() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLastAccessedTime
				/// </java-name>
				[Dot42.DexImport("getLastAccessedTime", "()J", AccessFlags = 1025)]
				long GetLastAccessedTime() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLocalCertificates
				/// </java-name>
				[Dot42.DexImport("getLocalCertificates", "()[Ljava/security/cert/Certificate;", AccessFlags = 1025)]
				global::Java.Security.Cert.Certificate[] GetLocalCertificates() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLocalPrincipal
				/// </java-name>
				[Dot42.DexImport("getLocalPrincipal", "()Ljava/security/Principal;", AccessFlags = 1025)]
				global::Java.Security.IPrincipal GetLocalPrincipal() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPacketBufferSize
				/// </java-name>
				[Dot42.DexImport("getPacketBufferSize", "()I", AccessFlags = 1025)]
				int GetPacketBufferSize() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPeerCertificateChain
				/// </java-name>
				[Dot42.DexImport("getPeerCertificateChain", "()[Ljavax/security/cert/X509Certificate;", AccessFlags = 1025)]
				global::Javax.Security.Cert.X509Certificate[] GetPeerCertificateChain() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPeerCertificates
				/// </java-name>
				[Dot42.DexImport("getPeerCertificates", "()[Ljava/security/cert/Certificate;", AccessFlags = 1025)]
				global::Java.Security.Cert.Certificate[] GetPeerCertificates() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPeerHost
				/// </java-name>
				[Dot42.DexImport("getPeerHost", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetPeerHost() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPeerPort
				/// </java-name>
				[Dot42.DexImport("getPeerPort", "()I", AccessFlags = 1025)]
				int GetPeerPort() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPeerPrincipal
				/// </java-name>
				[Dot42.DexImport("getPeerPrincipal", "()Ljava/security/Principal;", AccessFlags = 1025)]
				global::Java.Security.IPrincipal GetPeerPrincipal() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getProtocol
				/// </java-name>
				[Dot42.DexImport("getProtocol", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetProtocol() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSessionContext
				/// </java-name>
				[Dot42.DexImport("getSessionContext", "()Ljavax/net/ssl/SSLSessionContext;", AccessFlags = 1025)]
				global::Javax.Net.Ssl.ISSLSessionContext GetSessionContext() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetValue(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getValueNames
				/// </java-name>
				[Dot42.DexImport("getValueNames", "()[Ljava/lang/String;", AccessFlags = 1025)]
				string[] GetValueNames() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// invalidate
				/// </java-name>
				[Dot42.DexImport("invalidate", "()V", AccessFlags = 1025)]
				void Invalidate() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isValid
				/// </java-name>
				[Dot42.DexImport("isValid", "()Z", AccessFlags = 1025)]
				bool IsValid() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// putValue
				/// </java-name>
				[Dot42.DexImport("putValue", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1025)]
				void PutValue(string @string, object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeValue
				/// </java-name>
				[Dot42.DexImport("removeValue", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void RemoveValue(string @string) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/net/ssl/SSLException
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLException", AccessFlags = 33)]
		public partial class SSLException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SSLException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SSLException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SSLException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SSLException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// javax/net/ssl/SSLContext
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLContext", AccessFlags = 33)]
		public partial class SSLContext
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljavax/net/ssl/SSLContextSpi;Ljava/security/Provider;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal SSLContext(global::Javax.Net.Ssl.SSLContextSpi sSLContextSpi, global::Java.Security.Provider provider, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDefault
				/// </java-name>
				[Dot42.DexImport("getDefault", "()Ljavax/net/ssl/SSLContext;", AccessFlags = 9)]
				public static global::Javax.Net.Ssl.SSLContext GetDefault() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLContext);
				}

				/// <java-name>
				/// setDefault
				/// </java-name>
				[Dot42.DexImport("setDefault", "(Ljavax/net/ssl/SSLContext;)V", AccessFlags = 9)]
				public static void SetDefault(global::Javax.Net.Ssl.SSLContext sSLContext) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljavax/net/ssl/SSLContext;", AccessFlags = 9)]
				public static global::Javax.Net.Ssl.SSLContext GetInstance(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLContext);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/net/ssl/SSLContext;", AccessFlags = 9)]
				public static global::Javax.Net.Ssl.SSLContext GetInstance(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLContext);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/net/ssl/SSLContext;", AccessFlags = 9)]
				public static global::Javax.Net.Ssl.SSLContext GetInstance(string @string, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLContext);
				}

				/// <java-name>
				/// getProtocol
				/// </java-name>
				[Dot42.DexImport("getProtocol", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetProtocol() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
				public global::Java.Security.Provider GetProvider() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Provider);
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "([Ljavax/net/ssl/KeyManager;[Ljavax/net/ssl/TrustManager;Ljava/security/SecureRan" +
    "dom;)V", AccessFlags = 17)]
				public void Init(global::Javax.Net.Ssl.IKeyManager[] keyManager, global::Javax.Net.Ssl.ITrustManager[] trustManager, global::Java.Security.SecureRandom secureRandom) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSocketFactory
				/// </java-name>
				[Dot42.DexImport("getSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;", AccessFlags = 17)]
				public global::Javax.Net.Ssl.SSLSocketFactory GetSocketFactory() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLSocketFactory);
				}

				/// <java-name>
				/// getServerSocketFactory
				/// </java-name>
				[Dot42.DexImport("getServerSocketFactory", "()Ljavax/net/ssl/SSLServerSocketFactory;", AccessFlags = 17)]
				public global::Javax.Net.Ssl.SSLServerSocketFactory GetServerSocketFactory() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLServerSocketFactory);
				}

				/// <java-name>
				/// createSSLEngine
				/// </java-name>
				[Dot42.DexImport("createSSLEngine", "()Ljavax/net/ssl/SSLEngine;", AccessFlags = 17)]
				public global::Javax.Net.Ssl.SSLEngine CreateSSLEngine() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLEngine);
				}

				/// <java-name>
				/// createSSLEngine
				/// </java-name>
				[Dot42.DexImport("createSSLEngine", "(Ljava/lang/String;I)Ljavax/net/ssl/SSLEngine;", AccessFlags = 17)]
				public global::Javax.Net.Ssl.SSLEngine CreateSSLEngine(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLEngine);
				}

				/// <java-name>
				/// getServerSessionContext
				/// </java-name>
				[Dot42.DexImport("getServerSessionContext", "()Ljavax/net/ssl/SSLSessionContext;", AccessFlags = 17)]
				public global::Javax.Net.Ssl.ISSLSessionContext GetServerSessionContext() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.ISSLSessionContext);
				}

				/// <java-name>
				/// getClientSessionContext
				/// </java-name>
				[Dot42.DexImport("getClientSessionContext", "()Ljavax/net/ssl/SSLSessionContext;", AccessFlags = 17)]
				public global::Javax.Net.Ssl.ISSLSessionContext GetClientSessionContext() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.ISSLSessionContext);
				}

				/// <java-name>
				/// getDefaultSSLParameters
				/// </java-name>
				[Dot42.DexImport("getDefaultSSLParameters", "()Ljavax/net/ssl/SSLParameters;", AccessFlags = 17)]
				public global::Javax.Net.Ssl.SSLParameters GetDefaultSSLParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLParameters);
				}

				/// <java-name>
				/// getSupportedSSLParameters
				/// </java-name>
				[Dot42.DexImport("getSupportedSSLParameters", "()Ljavax/net/ssl/SSLParameters;", AccessFlags = 17)]
				public global::Javax.Net.Ssl.SSLParameters GetSupportedSSLParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLParameters);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SSLContext() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDefault
				/// </java-name>
				public static global::Javax.Net.Ssl.SSLContext Default
				{
				[Dot42.DexImport("getDefault", "()Ljavax/net/ssl/SSLContext;", AccessFlags = 9)]
						get{ return GetDefault(); }
				[Dot42.DexImport("setDefault", "(Ljavax/net/ssl/SSLContext;)V", AccessFlags = 9)]
						set{ SetDefault(value); }
				}

				/// <java-name>
				/// getProtocol
				/// </java-name>
				public string Protocol
				{
				[Dot42.DexImport("getProtocol", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetProtocol(); }
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return GetProvider(); }
				}

				/// <java-name>
				/// getSocketFactory
				/// </java-name>
				public global::Javax.Net.Ssl.SSLSocketFactory SocketFactory
				{
				[Dot42.DexImport("getSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;", AccessFlags = 17)]
						get{ return GetSocketFactory(); }
				}

				/// <java-name>
				/// getServerSocketFactory
				/// </java-name>
				public global::Javax.Net.Ssl.SSLServerSocketFactory ServerSocketFactory
				{
				[Dot42.DexImport("getServerSocketFactory", "()Ljavax/net/ssl/SSLServerSocketFactory;", AccessFlags = 17)]
						get{ return GetServerSocketFactory(); }
				}

				/// <java-name>
				/// getServerSessionContext
				/// </java-name>
				public global::Javax.Net.Ssl.ISSLSessionContext ServerSessionContext
				{
				[Dot42.DexImport("getServerSessionContext", "()Ljavax/net/ssl/SSLSessionContext;", AccessFlags = 17)]
						get{ return GetServerSessionContext(); }
				}

				/// <java-name>
				/// getClientSessionContext
				/// </java-name>
				public global::Javax.Net.Ssl.ISSLSessionContext ClientSessionContext
				{
				[Dot42.DexImport("getClientSessionContext", "()Ljavax/net/ssl/SSLSessionContext;", AccessFlags = 17)]
						get{ return GetClientSessionContext(); }
				}

				/// <java-name>
				/// getDefaultSSLParameters
				/// </java-name>
				public global::Javax.Net.Ssl.SSLParameters DefaultSSLParameters
				{
				[Dot42.DexImport("getDefaultSSLParameters", "()Ljavax/net/ssl/SSLParameters;", AccessFlags = 17)]
						get{ return GetDefaultSSLParameters(); }
				}

				/// <java-name>
				/// getSupportedSSLParameters
				/// </java-name>
				public global::Javax.Net.Ssl.SSLParameters SupportedSSLParameters
				{
				[Dot42.DexImport("getSupportedSSLParameters", "()Ljavax/net/ssl/SSLParameters;", AccessFlags = 17)]
						get{ return GetSupportedSSLParameters(); }
				}

		}

		/// <java-name>
		/// javax/net/ssl/HttpsURLConnection
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/HttpsURLConnection", AccessFlags = 1057)]
		public abstract partial class HttpsURLConnection : global::Java.Net.HttpURLConnection
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// hostnameVerifier
				/// </java-name>
				[Dot42.DexImport("hostnameVerifier", "Ljavax/net/ssl/HostnameVerifier;", AccessFlags = 4)]
				protected internal global::Javax.Net.Ssl.IHostnameVerifier HostnameVerifier;
				[Dot42.DexImport("<init>", "(Ljava/net/URL;)V", AccessFlags = 4)]
				protected internal HttpsURLConnection(global::Java.Net.URL uRL) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDefaultHostnameVerifier
				/// </java-name>
				[Dot42.DexImport("setDefaultHostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)V", AccessFlags = 9)]
				public static void SetDefaultHostnameVerifier(global::Javax.Net.Ssl.IHostnameVerifier hostnameVerifier) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDefaultHostnameVerifier
				/// </java-name>
				[Dot42.DexImport("getDefaultHostnameVerifier", "()Ljavax/net/ssl/HostnameVerifier;", AccessFlags = 9)]
				public static global::Javax.Net.Ssl.IHostnameVerifier GetDefaultHostnameVerifier() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.IHostnameVerifier);
				}

				/// <java-name>
				/// setDefaultSSLSocketFactory
				/// </java-name>
				[Dot42.DexImport("setDefaultSSLSocketFactory", "(Ljavax/net/ssl/SSLSocketFactory;)V", AccessFlags = 9)]
				public static void SetDefaultSSLSocketFactory(global::Javax.Net.Ssl.SSLSocketFactory sSLSocketFactory) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDefaultSSLSocketFactory
				/// </java-name>
				[Dot42.DexImport("getDefaultSSLSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;", AccessFlags = 9)]
				public static global::Javax.Net.Ssl.SSLSocketFactory GetDefaultSSLSocketFactory() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLSocketFactory);
				}

				/// <java-name>
				/// getCipherSuite
				/// </java-name>
				[Dot42.DexImport("getCipherSuite", "()Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string GetCipherSuite() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLocalCertificates
				/// </java-name>
				[Dot42.DexImport("getLocalCertificates", "()[Ljava/security/cert/Certificate;", AccessFlags = 1025)]
				public abstract global::Java.Security.Cert.Certificate[] GetLocalCertificates() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getServerCertificates
				/// </java-name>
				[Dot42.DexImport("getServerCertificates", "()[Ljava/security/cert/Certificate;", AccessFlags = 1025)]
				public abstract global::Java.Security.Cert.Certificate[] GetServerCertificates() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPeerPrincipal
				/// </java-name>
				[Dot42.DexImport("getPeerPrincipal", "()Ljava/security/Principal;", AccessFlags = 1)]
				public virtual global::Java.Security.IPrincipal GetPeerPrincipal() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IPrincipal);
				}

				/// <java-name>
				/// getLocalPrincipal
				/// </java-name>
				[Dot42.DexImport("getLocalPrincipal", "()Ljava/security/Principal;", AccessFlags = 1)]
				public virtual global::Java.Security.IPrincipal GetLocalPrincipal() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IPrincipal);
				}

				/// <java-name>
				/// setHostnameVerifier
				/// </java-name>
				[Dot42.DexImport("setHostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)V", AccessFlags = 1)]
				public virtual void SetHostnameVerifier(global::Javax.Net.Ssl.IHostnameVerifier hostnameVerifier) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getHostnameVerifier
				/// </java-name>
				[Dot42.DexImport("getHostnameVerifier", "()Ljavax/net/ssl/HostnameVerifier;", AccessFlags = 1)]
				public virtual global::Javax.Net.Ssl.IHostnameVerifier GetHostnameVerifier() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.IHostnameVerifier);
				}

				/// <java-name>
				/// setSSLSocketFactory
				/// </java-name>
				[Dot42.DexImport("setSSLSocketFactory", "(Ljavax/net/ssl/SSLSocketFactory;)V", AccessFlags = 1)]
				public virtual void SetSSLSocketFactory(global::Javax.Net.Ssl.SSLSocketFactory sSLSocketFactory) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSSLSocketFactory
				/// </java-name>
				[Dot42.DexImport("getSSLSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;", AccessFlags = 1)]
				public virtual global::Javax.Net.Ssl.SSLSocketFactory GetSSLSocketFactory() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLSocketFactory);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HttpsURLConnection() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDefaultHostnameVerifier
				/// </java-name>
				public static global::Javax.Net.Ssl.IHostnameVerifier DefaultHostnameVerifier
				{
				[Dot42.DexImport("getDefaultHostnameVerifier", "()Ljavax/net/ssl/HostnameVerifier;", AccessFlags = 9)]
						get{ return GetDefaultHostnameVerifier(); }
				[Dot42.DexImport("setDefaultHostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)V", AccessFlags = 9)]
						set{ SetDefaultHostnameVerifier(value); }
				}

				/// <java-name>
				/// getDefaultSSLSocketFactory
				/// </java-name>
				public static global::Javax.Net.Ssl.SSLSocketFactory DefaultSSLSocketFactory
				{
				[Dot42.DexImport("getDefaultSSLSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;", AccessFlags = 9)]
						get{ return GetDefaultSSLSocketFactory(); }
				[Dot42.DexImport("setDefaultSSLSocketFactory", "(Ljavax/net/ssl/SSLSocketFactory;)V", AccessFlags = 9)]
						set{ SetDefaultSSLSocketFactory(value); }
				}

				/// <java-name>
				/// getCipherSuite
				/// </java-name>
				public string CipherSuite
				{
				[Dot42.DexImport("getCipherSuite", "()Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetCipherSuite(); }
				}

				/// <java-name>
				/// getLocalCertificates
				/// </java-name>
				public global::Java.Security.Cert.Certificate[] LocalCertificates
				{
				[Dot42.DexImport("getLocalCertificates", "()[Ljava/security/cert/Certificate;", AccessFlags = 1025)]
						get{ return GetLocalCertificates(); }
				}

				/// <java-name>
				/// getServerCertificates
				/// </java-name>
				public global::Java.Security.Cert.Certificate[] ServerCertificates
				{
				[Dot42.DexImport("getServerCertificates", "()[Ljava/security/cert/Certificate;", AccessFlags = 1025)]
						get{ return GetServerCertificates(); }
				}

				/// <java-name>
				/// getPeerPrincipal
				/// </java-name>
				public global::Java.Security.IPrincipal PeerPrincipal
				{
				[Dot42.DexImport("getPeerPrincipal", "()Ljava/security/Principal;", AccessFlags = 1)]
						get{ return GetPeerPrincipal(); }
				}

				/// <java-name>
				/// getLocalPrincipal
				/// </java-name>
				public global::Java.Security.IPrincipal LocalPrincipal
				{
				[Dot42.DexImport("getLocalPrincipal", "()Ljava/security/Principal;", AccessFlags = 1)]
						get{ return GetLocalPrincipal(); }
				}

				/// <java-name>
				/// getSSLSocketFactory
				/// </java-name>
				public global::Javax.Net.Ssl.SSLSocketFactory SSLSocketFactory
				{
				[Dot42.DexImport("getSSLSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;", AccessFlags = 1)]
						get{ return GetSSLSocketFactory(); }
				[Dot42.DexImport("setSSLSocketFactory", "(Ljavax/net/ssl/SSLSocketFactory;)V", AccessFlags = 1)]
						set{ SetSSLSocketFactory(value); }
				}

		}

		/// <java-name>
		/// javax/net/ssl/KeyManagerFactory
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/KeyManagerFactory", AccessFlags = 33)]
		public partial class KeyManagerFactory
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljavax/net/ssl/KeyManagerFactorySpi;Ljava/security/Provider;Ljava/lang/String;)V" +
    "", AccessFlags = 4)]
				protected internal KeyManagerFactory(global::Javax.Net.Ssl.KeyManagerFactorySpi keyManagerFactorySpi, global::Java.Security.Provider provider, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDefaultAlgorithm
				/// </java-name>
				[Dot42.DexImport("getDefaultAlgorithm", "()Ljava/lang/String;", AccessFlags = 25)]
				public static string GetDefaultAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljavax/net/ssl/KeyManagerFactory;", AccessFlags = 25)]
				public static global::Javax.Net.Ssl.KeyManagerFactory GetInstance(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.KeyManagerFactory);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/net/ssl/KeyManagerFactory;", AccessFlags = 25)]
				public static global::Javax.Net.Ssl.KeyManagerFactory GetInstance(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.KeyManagerFactory);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/net/ssl/KeyManagerFactory;", AccessFlags = 25)]
				public static global::Javax.Net.Ssl.KeyManagerFactory GetInstance(string @string, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.KeyManagerFactory);
				}

				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
				public global::Java.Security.Provider GetProvider() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Provider);
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/KeyStore;[C)V", AccessFlags = 17)]
				public void Init(global::Java.Security.KeyStore keyStore, char[] @char) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljavax/net/ssl/ManagerFactoryParameters;)V", AccessFlags = 17)]
				public void Init(global::Javax.Net.Ssl.IManagerFactoryParameters managerFactoryParameters) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getKeyManagers
				/// </java-name>
				[Dot42.DexImport("getKeyManagers", "()[Ljavax/net/ssl/KeyManager;", AccessFlags = 17)]
				public global::Javax.Net.Ssl.IKeyManager[] GetKeyManagers() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.IKeyManager[]);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal KeyManagerFactory() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDefaultAlgorithm
				/// </java-name>
				public static string DefaultAlgorithm
				{
				[Dot42.DexImport("getDefaultAlgorithm", "()Ljava/lang/String;", AccessFlags = 25)]
						get{ return GetDefaultAlgorithm(); }
				}

				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetAlgorithm(); }
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return GetProvider(); }
				}

				/// <java-name>
				/// getKeyManagers
				/// </java-name>
				public global::Javax.Net.Ssl.IKeyManager[] KeyManagers
				{
				[Dot42.DexImport("getKeyManagers", "()[Ljavax/net/ssl/KeyManager;", AccessFlags = 17)]
						get{ return GetKeyManagers(); }
				}

		}

		/// <java-name>
		/// javax/net/ssl/SSLSocketFactory
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLSocketFactory", AccessFlags = 1057)]
		public abstract partial class SSLSocketFactory : global::Javax.Net.SocketFactory
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SSLSocketFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDefault
				/// </java-name>
				[Dot42.DexImport("getDefault", "()Ljavax/net/SocketFactory;", AccessFlags = 41)]
				public static global::Javax.Net.SocketFactory GetDefault() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.SocketFactory);
				}

				/// <java-name>
				/// getDefaultCipherSuites
				/// </java-name>
				[Dot42.DexImport("getDefaultCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetDefaultCipherSuites() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSupportedCipherSuites
				/// </java-name>
				[Dot42.DexImport("getSupportedCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetSupportedCipherSuites() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createSocket
				/// </java-name>
				[Dot42.DexImport("createSocket", "(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;", AccessFlags = 1025)]
				public abstract global::Java.Net.Socket CreateSocket(global::Java.Net.Socket socket, string @string, int int32, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDefault
				/// </java-name>
				public static global::Javax.Net.SocketFactory Default
				{
				[Dot42.DexImport("getDefault", "()Ljavax/net/SocketFactory;", AccessFlags = 41)]
						get{ return GetDefault(); }
				}

				/// <java-name>
				/// getDefaultCipherSuites
				/// </java-name>
				public string[] DefaultCipherSuites
				{
				[Dot42.DexImport("getDefaultCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetDefaultCipherSuites(); }
				}

				/// <java-name>
				/// getSupportedCipherSuites
				/// </java-name>
				public string[] SupportedCipherSuites
				{
				[Dot42.DexImport("getSupportedCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetSupportedCipherSuites(); }
				}

		}

		/// <java-name>
		/// javax/net/ssl/ManagerFactoryParameters
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/ManagerFactoryParameters", AccessFlags = 1537)]
		public partial interface IManagerFactoryParameters
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// javax/net/ssl/KeyStoreBuilderParameters
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/KeyStoreBuilderParameters", AccessFlags = 33)]
		public partial class KeyStoreBuilderParameters : global::Javax.Net.Ssl.IManagerFactoryParameters
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/security/KeyStore$Builder;)V", AccessFlags = 1)]
				public KeyStoreBuilderParameters(global::Java.Security.KeyStore.Builder builder) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/List;)V", AccessFlags = 1, Signature = "(Ljava/util/List<Ljava/security/KeyStore$Builder;>;)V")]
				public KeyStoreBuilderParameters(global::Java.Util.IList<global::Java.Security.KeyStore.Builder> list) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getParameters
				/// </java-name>
				[Dot42.DexImport("getParameters", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/security/KeyStore$Builder;>;")]
				public virtual global::Java.Util.IList<global::Java.Security.KeyStore.Builder> GetParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Java.Security.KeyStore.Builder>);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal KeyStoreBuilderParameters() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getParameters
				/// </java-name>
				public global::Java.Util.IList<global::Java.Security.KeyStore.Builder> Parameters
				{
				[Dot42.DexImport("getParameters", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/security/KeyStore$Builder;>;")]
						get{ return GetParameters(); }
				}

		}

		/// <java-name>
		/// javax/net/ssl/HandshakeCompletedListener
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/HandshakeCompletedListener", AccessFlags = 1537)]
		public partial interface IHandshakeCompletedListener : global::Java.Util.IEventListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// handshakeCompleted
				/// </java-name>
				[Dot42.DexImport("handshakeCompleted", "(Ljavax/net/ssl/HandshakeCompletedEvent;)V", AccessFlags = 1025)]
				void HandshakeCompleted(global::Javax.Net.Ssl.HandshakeCompletedEvent handshakeCompletedEvent) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/net/ssl/TrustManagerFactory
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/TrustManagerFactory", AccessFlags = 33)]
		public partial class TrustManagerFactory
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljavax/net/ssl/TrustManagerFactorySpi;Ljava/security/Provider;Ljava/lang/String;" +
    ")V", AccessFlags = 4)]
				protected internal TrustManagerFactory(global::Javax.Net.Ssl.TrustManagerFactorySpi trustManagerFactorySpi, global::Java.Security.Provider provider, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDefaultAlgorithm
				/// </java-name>
				[Dot42.DexImport("getDefaultAlgorithm", "()Ljava/lang/String;", AccessFlags = 25)]
				public static string GetDefaultAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljavax/net/ssl/TrustManagerFactory;", AccessFlags = 25)]
				public static global::Javax.Net.Ssl.TrustManagerFactory GetInstance(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.TrustManagerFactory);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/net/ssl/TrustManagerFactory;", AccessFlags = 25)]
				public static global::Javax.Net.Ssl.TrustManagerFactory GetInstance(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.TrustManagerFactory);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/net/ssl/TrustManagerFactory;", AccessFlags = 25)]
				public static global::Javax.Net.Ssl.TrustManagerFactory GetInstance(string @string, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.TrustManagerFactory);
				}

				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
				public global::Java.Security.Provider GetProvider() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Provider);
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/KeyStore;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.KeyStore keyStore) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljavax/net/ssl/ManagerFactoryParameters;)V", AccessFlags = 17)]
				public void Init(global::Javax.Net.Ssl.IManagerFactoryParameters managerFactoryParameters) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTrustManagers
				/// </java-name>
				[Dot42.DexImport("getTrustManagers", "()[Ljavax/net/ssl/TrustManager;", AccessFlags = 17)]
				public global::Javax.Net.Ssl.ITrustManager[] GetTrustManagers() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.ITrustManager[]);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TrustManagerFactory() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDefaultAlgorithm
				/// </java-name>
				public static string DefaultAlgorithm
				{
				[Dot42.DexImport("getDefaultAlgorithm", "()Ljava/lang/String;", AccessFlags = 25)]
						get{ return GetDefaultAlgorithm(); }
				}

				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetAlgorithm(); }
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return GetProvider(); }
				}

				/// <java-name>
				/// getTrustManagers
				/// </java-name>
				public global::Javax.Net.Ssl.ITrustManager[] TrustManagers
				{
				[Dot42.DexImport("getTrustManagers", "()[Ljavax/net/ssl/TrustManager;", AccessFlags = 17)]
						get{ return GetTrustManagers(); }
				}

		}

		/// <java-name>
		/// javax/net/ssl/X509KeyManager
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/X509KeyManager", AccessFlags = 1537)]
		public partial interface IX509KeyManager : global::Javax.Net.Ssl.IKeyManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// chooseClientAlias
				/// </java-name>
				[Dot42.DexImport("chooseClientAlias", "([Ljava/lang/String;[Ljava/security/Principal;Ljava/net/Socket;)Ljava/lang/String" +
    ";", AccessFlags = 1025)]
				string ChooseClientAlias(string[] @string, global::Java.Security.IPrincipal[] principal, global::Java.Net.Socket socket) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// chooseServerAlias
				/// </java-name>
				[Dot42.DexImport("chooseServerAlias", "(Ljava/lang/String;[Ljava/security/Principal;Ljava/net/Socket;)Ljava/lang/String;" +
    "", AccessFlags = 1025)]
				string ChooseServerAlias(string @string, global::Java.Security.IPrincipal[] principal, global::Java.Net.Socket socket) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCertificateChain
				/// </java-name>
				[Dot42.DexImport("getCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/X509Certificate;", AccessFlags = 1025)]
				global::Java.Security.Cert.X509Certificate[] GetCertificateChain(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getClientAliases
				/// </java-name>
				[Dot42.DexImport("getClientAliases", "(Ljava/lang/String;[Ljava/security/Principal;)[Ljava/lang/String;", AccessFlags = 1025)]
				string[] GetClientAliases(string @string, global::Java.Security.IPrincipal[] principal) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getServerAliases
				/// </java-name>
				[Dot42.DexImport("getServerAliases", "(Ljava/lang/String;[Ljava/security/Principal;)[Ljava/lang/String;", AccessFlags = 1025)]
				string[] GetServerAliases(string @string, global::Java.Security.IPrincipal[] principal) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPrivateKey
				/// </java-name>
				[Dot42.DexImport("getPrivateKey", "(Ljava/lang/String;)Ljava/security/PrivateKey;", AccessFlags = 1025)]
				global::Java.Security.IPrivateKey GetPrivateKey(string @string) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/net/ssl/X509TrustManager
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/X509TrustManager", AccessFlags = 1537)]
		public partial interface IX509TrustManager : global::Javax.Net.Ssl.ITrustManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// checkClientTrusted
				/// </java-name>
				[Dot42.DexImport("checkClientTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V", AccessFlags = 1025)]
				void CheckClientTrusted(global::Java.Security.Cert.X509Certificate[] x509Certificate, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// checkServerTrusted
				/// </java-name>
				[Dot42.DexImport("checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V", AccessFlags = 1025)]
				void CheckServerTrusted(global::Java.Security.Cert.X509Certificate[] x509Certificate, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAcceptedIssuers
				/// </java-name>
				[Dot42.DexImport("getAcceptedIssuers", "()[Ljava/security/cert/X509Certificate;", AccessFlags = 1025)]
				global::Java.Security.Cert.X509Certificate[] GetAcceptedIssuers() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/net/ssl/SSLPermission
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLPermission", AccessFlags = 49)]
		public sealed partial class SSLPermission : global::Java.Security.BasicPermission
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SSLPermission(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public SSLPermission(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetActions() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// implies
				/// </java-name>
				[Dot42.DexImport("implies", "(Ljava/security/Permission;)Z", AccessFlags = 1)]
				public override bool Implies(global::Java.Security.Permission permission) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SSLPermission() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				public string Actions
				{
				[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetActions(); }
				}

		}

		/// <java-name>
		/// javax/net/ssl/TrustManager
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/TrustManager", AccessFlags = 1537)]
		public partial interface ITrustManager
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// javax/net/ssl/SSLServerSocket
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLServerSocket", AccessFlags = 1057)]
		public abstract partial class SSLServerSocket : global::Java.Net.ServerSocket
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal SSLServerSocket() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 4)]
				protected internal SSLServerSocket(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 4)]
				protected internal SSLServerSocket(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IILjava/net/InetAddress;)V", AccessFlags = 4)]
				protected internal SSLServerSocket(int int32, int int321, global::Java.Net.InetAddress inetAddress) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getEnabledCipherSuites
				/// </java-name>
				[Dot42.DexImport("getEnabledCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetEnabledCipherSuites() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setEnabledCipherSuites
				/// </java-name>
				[Dot42.DexImport("setEnabledCipherSuites", "([Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void SetEnabledCipherSuites(string[] @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSupportedCipherSuites
				/// </java-name>
				[Dot42.DexImport("getSupportedCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetSupportedCipherSuites() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSupportedProtocols
				/// </java-name>
				[Dot42.DexImport("getSupportedProtocols", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetSupportedProtocols() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getEnabledProtocols
				/// </java-name>
				[Dot42.DexImport("getEnabledProtocols", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetEnabledProtocols() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setEnabledProtocols
				/// </java-name>
				[Dot42.DexImport("setEnabledProtocols", "([Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void SetEnabledProtocols(string[] @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNeedClientAuth
				/// </java-name>
				[Dot42.DexImport("setNeedClientAuth", "(Z)V", AccessFlags = 1025)]
				public abstract void SetNeedClientAuth(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getNeedClientAuth
				/// </java-name>
				[Dot42.DexImport("getNeedClientAuth", "()Z", AccessFlags = 1025)]
				public abstract bool GetNeedClientAuth() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setWantClientAuth
				/// </java-name>
				[Dot42.DexImport("setWantClientAuth", "(Z)V", AccessFlags = 1025)]
				public abstract void SetWantClientAuth(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getWantClientAuth
				/// </java-name>
				[Dot42.DexImport("getWantClientAuth", "()Z", AccessFlags = 1025)]
				public abstract bool GetWantClientAuth() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setUseClientMode
				/// </java-name>
				[Dot42.DexImport("setUseClientMode", "(Z)V", AccessFlags = 1025)]
				public abstract void SetUseClientMode(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getUseClientMode
				/// </java-name>
				[Dot42.DexImport("getUseClientMode", "()Z", AccessFlags = 1025)]
				public abstract bool GetUseClientMode() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setEnableSessionCreation
				/// </java-name>
				[Dot42.DexImport("setEnableSessionCreation", "(Z)V", AccessFlags = 1025)]
				public abstract void SetEnableSessionCreation(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getEnableSessionCreation
				/// </java-name>
				[Dot42.DexImport("getEnableSessionCreation", "()Z", AccessFlags = 1025)]
				public abstract bool GetEnableSessionCreation() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getEnabledCipherSuites
				/// </java-name>
				public string[] EnabledCipherSuites
				{
				[Dot42.DexImport("getEnabledCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetEnabledCipherSuites(); }
				[Dot42.DexImport("setEnabledCipherSuites", "([Ljava/lang/String;)V", AccessFlags = 1025)]
						set{ SetEnabledCipherSuites(value); }
				}

				/// <java-name>
				/// getSupportedCipherSuites
				/// </java-name>
				public string[] SupportedCipherSuites
				{
				[Dot42.DexImport("getSupportedCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetSupportedCipherSuites(); }
				}

				/// <java-name>
				/// getSupportedProtocols
				/// </java-name>
				public string[] SupportedProtocols
				{
				[Dot42.DexImport("getSupportedProtocols", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetSupportedProtocols(); }
				}

				/// <java-name>
				/// getEnabledProtocols
				/// </java-name>
				public string[] EnabledProtocols
				{
				[Dot42.DexImport("getEnabledProtocols", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetEnabledProtocols(); }
				[Dot42.DexImport("setEnabledProtocols", "([Ljava/lang/String;)V", AccessFlags = 1025)]
						set{ SetEnabledProtocols(value); }
				}

				/// <java-name>
				/// getNeedClientAuth
				/// </java-name>
				public bool IsNeedClientAuth
				{
				[Dot42.DexImport("getNeedClientAuth", "()Z", AccessFlags = 1025)]
						get{ return GetNeedClientAuth(); }
				[Dot42.DexImport("setNeedClientAuth", "(Z)V", AccessFlags = 1025)]
						set{ SetNeedClientAuth(value); }
				}

				/// <java-name>
				/// getWantClientAuth
				/// </java-name>
				public bool IsWantClientAuth
				{
				[Dot42.DexImport("getWantClientAuth", "()Z", AccessFlags = 1025)]
						get{ return GetWantClientAuth(); }
				[Dot42.DexImport("setWantClientAuth", "(Z)V", AccessFlags = 1025)]
						set{ SetWantClientAuth(value); }
				}

				/// <java-name>
				/// getUseClientMode
				/// </java-name>
				public bool IsUseClientMode
				{
				[Dot42.DexImport("getUseClientMode", "()Z", AccessFlags = 1025)]
						get{ return GetUseClientMode(); }
				[Dot42.DexImport("setUseClientMode", "(Z)V", AccessFlags = 1025)]
						set{ SetUseClientMode(value); }
				}

				/// <java-name>
				/// getEnableSessionCreation
				/// </java-name>
				public bool IsEnableSessionCreation
				{
				[Dot42.DexImport("getEnableSessionCreation", "()Z", AccessFlags = 1025)]
						get{ return GetEnableSessionCreation(); }
				[Dot42.DexImport("setEnableSessionCreation", "(Z)V", AccessFlags = 1025)]
						set{ SetEnableSessionCreation(value); }
				}

		}

		/// <java-name>
		/// javax/net/ssl/KeyManagerFactorySpi
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/KeyManagerFactorySpi", AccessFlags = 1057)]
		public abstract partial class KeyManagerFactorySpi
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public KeyManagerFactorySpi() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(Ljava/security/KeyStore;[C)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(global::Java.Security.KeyStore keyStore, char[] @char) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(Ljavax/net/ssl/ManagerFactoryParameters;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(global::Javax.Net.Ssl.IManagerFactoryParameters managerFactoryParameters) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGetKeyManagers
				/// </java-name>
				[Dot42.DexImport("engineGetKeyManagers", "()[Ljavax/net/ssl/KeyManager;", AccessFlags = 1028)]
				protected internal abstract global::Javax.Net.Ssl.IKeyManager[] EngineGetKeyManagers() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/net/ssl/SSLEngine
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLEngine", AccessFlags = 1057)]
		public abstract partial class SSLEngine
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal SSLEngine() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 4)]
				protected internal SSLEngine(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPeerHost
				/// </java-name>
				[Dot42.DexImport("getPeerHost", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPeerHost() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getPeerPort
				/// </java-name>
				[Dot42.DexImport("getPeerPort", "()I", AccessFlags = 1)]
				public virtual int GetPeerPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// beginHandshake
				/// </java-name>
				[Dot42.DexImport("beginHandshake", "()V", AccessFlags = 1025)]
				public abstract void BeginHandshake() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// closeInbound
				/// </java-name>
				[Dot42.DexImport("closeInbound", "()V", AccessFlags = 1025)]
				public abstract void CloseInbound() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// closeOutbound
				/// </java-name>
				[Dot42.DexImport("closeOutbound", "()V", AccessFlags = 1025)]
				public abstract void CloseOutbound() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDelegatedTask
				/// </java-name>
				[Dot42.DexImport("getDelegatedTask", "()Ljava/lang/Runnable;", AccessFlags = 1025)]
				public abstract global::Java.Lang.IRunnable GetDelegatedTask() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getEnabledCipherSuites
				/// </java-name>
				[Dot42.DexImport("getEnabledCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetEnabledCipherSuites() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getEnabledProtocols
				/// </java-name>
				[Dot42.DexImport("getEnabledProtocols", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetEnabledProtocols() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getEnableSessionCreation
				/// </java-name>
				[Dot42.DexImport("getEnableSessionCreation", "()Z", AccessFlags = 1025)]
				public abstract bool GetEnableSessionCreation() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getHandshakeStatus
				/// </java-name>
				[Dot42.DexImport("getHandshakeStatus", "()Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", AccessFlags = 1025)]
				public abstract global::Javax.Net.Ssl.SSLEngineResult.HandshakeStatus GetHandshakeStatus() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getNeedClientAuth
				/// </java-name>
				[Dot42.DexImport("getNeedClientAuth", "()Z", AccessFlags = 1025)]
				public abstract bool GetNeedClientAuth() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSession
				/// </java-name>
				[Dot42.DexImport("getSession", "()Ljavax/net/ssl/SSLSession;", AccessFlags = 1025)]
				public abstract global::Javax.Net.Ssl.ISSLSession GetSession() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSupportedCipherSuites
				/// </java-name>
				[Dot42.DexImport("getSupportedCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetSupportedCipherSuites() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSupportedProtocols
				/// </java-name>
				[Dot42.DexImport("getSupportedProtocols", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetSupportedProtocols() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getUseClientMode
				/// </java-name>
				[Dot42.DexImport("getUseClientMode", "()Z", AccessFlags = 1025)]
				public abstract bool GetUseClientMode() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getWantClientAuth
				/// </java-name>
				[Dot42.DexImport("getWantClientAuth", "()Z", AccessFlags = 1025)]
				public abstract bool GetWantClientAuth() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isInboundDone
				/// </java-name>
				[Dot42.DexImport("isInboundDone", "()Z", AccessFlags = 1025)]
				public abstract bool IsInboundDone() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isOutboundDone
				/// </java-name>
				[Dot42.DexImport("isOutboundDone", "()Z", AccessFlags = 1025)]
				public abstract bool IsOutboundDone() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setEnabledCipherSuites
				/// </java-name>
				[Dot42.DexImport("setEnabledCipherSuites", "([Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void SetEnabledCipherSuites(string[] @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setEnabledProtocols
				/// </java-name>
				[Dot42.DexImport("setEnabledProtocols", "([Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void SetEnabledProtocols(string[] @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setEnableSessionCreation
				/// </java-name>
				[Dot42.DexImport("setEnableSessionCreation", "(Z)V", AccessFlags = 1025)]
				public abstract void SetEnableSessionCreation(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNeedClientAuth
				/// </java-name>
				[Dot42.DexImport("setNeedClientAuth", "(Z)V", AccessFlags = 1025)]
				public abstract void SetNeedClientAuth(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setUseClientMode
				/// </java-name>
				[Dot42.DexImport("setUseClientMode", "(Z)V", AccessFlags = 1025)]
				public abstract void SetUseClientMode(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setWantClientAuth
				/// </java-name>
				[Dot42.DexImport("setWantClientAuth", "(Z)V", AccessFlags = 1025)]
				public abstract void SetWantClientAuth(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// unwrap
				/// </java-name>
				[Dot42.DexImport("unwrap", "(Ljava/nio/ByteBuffer;[Ljava/nio/ByteBuffer;II)Ljavax/net/ssl/SSLEngineResult;", AccessFlags = 1025)]
				public abstract global::Javax.Net.Ssl.SSLEngineResult Unwrap(global::Java.Nio.ByteBuffer byteBuffer, global::Java.Nio.ByteBuffer[] byteBuffer1, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([Ljava/nio/ByteBuffer;IILjava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;", AccessFlags = 1025)]
				public abstract global::Javax.Net.Ssl.SSLEngineResult Wrap(global::Java.Nio.ByteBuffer[] byteBuffer, int int32, int int321, global::Java.Nio.ByteBuffer byteBuffer1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// unwrap
				/// </java-name>
				[Dot42.DexImport("unwrap", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;", AccessFlags = 1)]
				public virtual global::Javax.Net.Ssl.SSLEngineResult Unwrap(global::Java.Nio.ByteBuffer byteBuffer, global::Java.Nio.ByteBuffer byteBuffer1) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLEngineResult);
				}

				/// <java-name>
				/// unwrap
				/// </java-name>
				[Dot42.DexImport("unwrap", "(Ljava/nio/ByteBuffer;[Ljava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;", AccessFlags = 1)]
				public virtual global::Javax.Net.Ssl.SSLEngineResult Unwrap(global::Java.Nio.ByteBuffer byteBuffer, global::Java.Nio.ByteBuffer[] byteBuffer1) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLEngineResult);
				}

				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;", AccessFlags = 1)]
				public virtual global::Javax.Net.Ssl.SSLEngineResult Wrap(global::Java.Nio.ByteBuffer[] byteBuffer, global::Java.Nio.ByteBuffer byteBuffer1) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLEngineResult);
				}

				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;", AccessFlags = 1)]
				public virtual global::Javax.Net.Ssl.SSLEngineResult Wrap(global::Java.Nio.ByteBuffer byteBuffer, global::Java.Nio.ByteBuffer byteBuffer1) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLEngineResult);
				}

				/// <java-name>
				/// getSSLParameters
				/// </java-name>
				[Dot42.DexImport("getSSLParameters", "()Ljavax/net/ssl/SSLParameters;", AccessFlags = 1)]
				public virtual global::Javax.Net.Ssl.SSLParameters GetSSLParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLParameters);
				}

				/// <java-name>
				/// setSSLParameters
				/// </java-name>
				[Dot42.DexImport("setSSLParameters", "(Ljavax/net/ssl/SSLParameters;)V", AccessFlags = 1)]
				public virtual void SetSSLParameters(global::Javax.Net.Ssl.SSLParameters sSLParameters) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPeerHost
				/// </java-name>
				public string PeerHost
				{
				[Dot42.DexImport("getPeerHost", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPeerHost(); }
				}

				/// <java-name>
				/// getPeerPort
				/// </java-name>
				public int PeerPort
				{
				[Dot42.DexImport("getPeerPort", "()I", AccessFlags = 1)]
						get{ return GetPeerPort(); }
				}

				/// <java-name>
				/// getDelegatedTask
				/// </java-name>
				public global::Java.Lang.IRunnable DelegatedTask
				{
				[Dot42.DexImport("getDelegatedTask", "()Ljava/lang/Runnable;", AccessFlags = 1025)]
						get{ return GetDelegatedTask(); }
				}

				/// <java-name>
				/// getEnabledCipherSuites
				/// </java-name>
				public string[] EnabledCipherSuites
				{
				[Dot42.DexImport("getEnabledCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetEnabledCipherSuites(); }
				[Dot42.DexImport("setEnabledCipherSuites", "([Ljava/lang/String;)V", AccessFlags = 1025)]
						set{ SetEnabledCipherSuites(value); }
				}

				/// <java-name>
				/// getEnabledProtocols
				/// </java-name>
				public string[] EnabledProtocols
				{
				[Dot42.DexImport("getEnabledProtocols", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetEnabledProtocols(); }
				[Dot42.DexImport("setEnabledProtocols", "([Ljava/lang/String;)V", AccessFlags = 1025)]
						set{ SetEnabledProtocols(value); }
				}

				/// <java-name>
				/// getEnableSessionCreation
				/// </java-name>
				public bool IsEnableSessionCreation
				{
				[Dot42.DexImport("getEnableSessionCreation", "()Z", AccessFlags = 1025)]
						get{ return GetEnableSessionCreation(); }
				[Dot42.DexImport("setEnableSessionCreation", "(Z)V", AccessFlags = 1025)]
						set{ SetEnableSessionCreation(value); }
				}

				/// <java-name>
				/// getHandshakeStatus
				/// </java-name>
				public global::Javax.Net.Ssl.SSLEngineResult.HandshakeStatus HandshakeStatus
				{
				[Dot42.DexImport("getHandshakeStatus", "()Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", AccessFlags = 1025)]
						get{ return GetHandshakeStatus(); }
				}

				/// <java-name>
				/// getNeedClientAuth
				/// </java-name>
				public bool IsNeedClientAuth
				{
				[Dot42.DexImport("getNeedClientAuth", "()Z", AccessFlags = 1025)]
						get{ return GetNeedClientAuth(); }
				[Dot42.DexImport("setNeedClientAuth", "(Z)V", AccessFlags = 1025)]
						set{ SetNeedClientAuth(value); }
				}

				/// <java-name>
				/// getSession
				/// </java-name>
				public global::Javax.Net.Ssl.ISSLSession Session
				{
				[Dot42.DexImport("getSession", "()Ljavax/net/ssl/SSLSession;", AccessFlags = 1025)]
						get{ return GetSession(); }
				}

				/// <java-name>
				/// getSupportedCipherSuites
				/// </java-name>
				public string[] SupportedCipherSuites
				{
				[Dot42.DexImport("getSupportedCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetSupportedCipherSuites(); }
				}

				/// <java-name>
				/// getSupportedProtocols
				/// </java-name>
				public string[] SupportedProtocols
				{
				[Dot42.DexImport("getSupportedProtocols", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetSupportedProtocols(); }
				}

				/// <java-name>
				/// getUseClientMode
				/// </java-name>
				public bool IsUseClientMode
				{
				[Dot42.DexImport("getUseClientMode", "()Z", AccessFlags = 1025)]
						get{ return GetUseClientMode(); }
				[Dot42.DexImport("setUseClientMode", "(Z)V", AccessFlags = 1025)]
						set{ SetUseClientMode(value); }
				}

				/// <java-name>
				/// getWantClientAuth
				/// </java-name>
				public bool IsWantClientAuth
				{
				[Dot42.DexImport("getWantClientAuth", "()Z", AccessFlags = 1025)]
						get{ return GetWantClientAuth(); }
				[Dot42.DexImport("setWantClientAuth", "(Z)V", AccessFlags = 1025)]
						set{ SetWantClientAuth(value); }
				}

				/// <java-name>
				/// getSSLParameters
				/// </java-name>
				public global::Javax.Net.Ssl.SSLParameters SSLParameters
				{
				[Dot42.DexImport("getSSLParameters", "()Ljavax/net/ssl/SSLParameters;", AccessFlags = 1)]
						get{ return GetSSLParameters(); }
				[Dot42.DexImport("setSSLParameters", "(Ljavax/net/ssl/SSLParameters;)V", AccessFlags = 1)]
						set{ SetSSLParameters(value); }
				}

		}

}

