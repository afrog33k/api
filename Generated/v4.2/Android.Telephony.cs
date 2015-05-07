﻿#pragma warning disable 1717
namespace Android.Telephony
{
		/// <summary>
		///  <para>CellIdentity is to represent a unique CDMA cell </para>    
		/// </summary>
		/// <java-name>
		/// android/telephony/CellIdentityCdma
		/// </java-name>
		[Dot42.DexImport("android/telephony/CellIdentityCdma", AccessFlags = 49)]
		public sealed partial class CellIdentityCdma : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Telephony.CellIdentityCdma> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal CellIdentityCdma() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object other) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Network Id 0..65535, Integer.MAX_VALUE if unknown </para>
				/// </returns>
				/// <java-name>
				/// getNetworkId
				/// </java-name>
				public int NetworkId
				{
						[Dot42.DexImport("getNetworkId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>System Id 0..32767, Integer.MAX_VALUE if unknown </para>
				/// </returns>
				/// <java-name>
				/// getSystemId
				/// </java-name>
				public int SystemId
				{
						[Dot42.DexImport("getSystemId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Base Station Id 0..65535, Integer.MAX_VALUE if unknown </para>
				/// </returns>
				/// <java-name>
				/// getBasestationId
				/// </java-name>
				public int BasestationId
				{
						[Dot42.DexImport("getBasestationId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Base station longitude, which is a decimal number as specified in 3GPP2 C.S0005-A v6.0. It is represented in units of 0.25 seconds and ranges from -2592000 to 2592000, both values inclusive (corresponding to a range of -180 to +180 degrees). Integer.MAX_VALUE if unknown. </para>
				/// </returns>
				/// <java-name>
				/// getLongitude
				/// </java-name>
				public int Longitude
				{
						[Dot42.DexImport("getLongitude", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Base station latitude, which is a decimal number as specified in 3GPP2 C.S0005-A v6.0. It is represented in units of 0.25 seconds and ranges from -1296000 to 1296000, both values inclusive (corresponding to a range of -90 to +90 degrees). Integer.MAX_VALUE if unknown. </para>
				/// </returns>
				/// <java-name>
				/// getLatitude
				/// </java-name>
				public int Latitude
				{
						[Dot42.DexImport("getLatitude", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>CellIdentity to represent a unique GSM cell </para>    
		/// </summary>
		/// <java-name>
		/// android/telephony/CellIdentityGsm
		/// </java-name>
		[Dot42.DexImport("android/telephony/CellIdentityGsm", AccessFlags = 49)]
		public sealed partial class CellIdentityGsm : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Telephony.CellIdentityGsm> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal CellIdentityGsm() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object other) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>3-digit Mobile Country Code, 0..999, Integer.MAX_VALUE if unknown </para>
				/// </returns>
				/// <java-name>
				/// getMcc
				/// </java-name>
				public int Mcc
				{
						[Dot42.DexImport("getMcc", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>2 or 3-digit Mobile Network Code, 0..999, Integer.MAX_VALUE if unknown </para>
				/// </returns>
				/// <java-name>
				/// getMnc
				/// </java-name>
				public int Mnc
				{
						[Dot42.DexImport("getMnc", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>16-bit Location Area Code, 0..65535, Integer.MAX_VALUE if unknown </para>
				/// </returns>
				/// <java-name>
				/// getLac
				/// </java-name>
				public int Lac
				{
						[Dot42.DexImport("getLac", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>CID Either 16-bit GSM Cell Identity described in TS 27.007, 0..65535, Integer.MAX_VALUE if unknown </para>
				/// </returns>
				/// <java-name>
				/// getCid
				/// </java-name>
				public int Cid
				{
						[Dot42.DexImport("getCid", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Integer.MAX_VALUE, undefined for GSM </para>
				/// </returns>
				/// <java-name>
				/// getPsc
				/// </java-name>
				public int Psc
				{
						[Dot42.DexImport("getPsc", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>CellIdentity is to represent a unique LTE cell </para>    
		/// </summary>
		/// <java-name>
		/// android/telephony/CellIdentityLte
		/// </java-name>
		[Dot42.DexImport("android/telephony/CellIdentityLte", AccessFlags = 49)]
		public sealed partial class CellIdentityLte : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Telephony.CellIdentityLte> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal CellIdentityLte() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object other) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>3-digit Mobile Country Code, 0..999, Integer.MAX_VALUE if unknown </para>
				/// </returns>
				/// <java-name>
				/// getMcc
				/// </java-name>
				public int Mcc
				{
						[Dot42.DexImport("getMcc", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>2 or 3-digit Mobile Network Code, 0..999, Integer.MAX_VALUE if unknown </para>
				/// </returns>
				/// <java-name>
				/// getMnc
				/// </java-name>
				public int Mnc
				{
						[Dot42.DexImport("getMnc", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>28-bit Cell Identity, Integer.MAX_VALUE if unknown </para>
				/// </returns>
				/// <java-name>
				/// getCi
				/// </java-name>
				public int Ci
				{
						[Dot42.DexImport("getCi", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Physical Cell Id 0..503, Integer.MAX_VALUE if unknown </para>
				/// </returns>
				/// <java-name>
				/// getPci
				/// </java-name>
				public int Pci
				{
						[Dot42.DexImport("getPci", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>16-bit Tracking Area Code, Integer.MAX_VALUE if unknown </para>
				/// </returns>
				/// <java-name>
				/// getTac
				/// </java-name>
				public int Tac
				{
						[Dot42.DexImport("getTac", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>Immutable cell information from a point in time. </para>    
		/// </summary>
		/// <java-name>
		/// android/telephony/CellInfo
		/// </java-name>
		[Dot42.DexImport("android/telephony/CellInfo", AccessFlags = 1057)]
		public abstract partial class CellInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Telephony.CellInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal CellInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object other) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1025)]
				public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>True if this cell is registered to the mobile network </para>        
				/// </summary>
				/// <java-name>
				/// isRegistered
				/// </java-name>
				public virtual bool IsRegistered
				{
						[Dot42.DexImport("isRegistered", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Approximate time of this cell information in nanos since boot </para>        
				/// </summary>
				/// <java-name>
				/// getTimeStamp
				/// </java-name>
				public virtual long TimeStamp
				{
						[Dot42.DexImport("getTimeStamp", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

		}

		/// <summary>
		///  <para>Immutable cell information from a point in time. </para>    
		/// </summary>
		/// <java-name>
		/// android/telephony/CellInfoCdma
		/// </java-name>
		[Dot42.DexImport("android/telephony/CellInfoCdma", AccessFlags = 49)]
		public sealed partial class CellInfoCdma : global::Android.Telephony.CellInfo, global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Telephony.CellInfoCdma> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal CellInfoCdma() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>hash code </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object other) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public override int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public override void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCellIdentity
				/// </java-name>
				public global::Android.Telephony.CellIdentityCdma CellIdentity
				{
						[Dot42.DexImport("getCellIdentity", "()Landroid/telephony/CellIdentityCdma;", AccessFlags = 1)]
						get{ return default(global::Android.Telephony.CellIdentityCdma); }
				}

				/// <java-name>
				/// getCellSignalStrength
				/// </java-name>
				public global::Android.Telephony.CellSignalStrengthCdma CellSignalStrength
				{
						[Dot42.DexImport("getCellSignalStrength", "()Landroid/telephony/CellSignalStrengthCdma;", AccessFlags = 1)]
						get{ return default(global::Android.Telephony.CellSignalStrengthCdma); }
				}

		}

		/// <summary>
		///  <para>Immutable cell information from a point in time. </para>    
		/// </summary>
		/// <java-name>
		/// android/telephony/CellInfoGsm
		/// </java-name>
		[Dot42.DexImport("android/telephony/CellInfoGsm", AccessFlags = 49)]
		public sealed partial class CellInfoGsm : global::Android.Telephony.CellInfo, global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Telephony.CellInfoGsm> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal CellInfoGsm() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>hash code </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object other) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public override int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public override void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCellIdentity
				/// </java-name>
				public global::Android.Telephony.CellIdentityGsm CellIdentity
				{
						[Dot42.DexImport("getCellIdentity", "()Landroid/telephony/CellIdentityGsm;", AccessFlags = 1)]
						get{ return default(global::Android.Telephony.CellIdentityGsm); }
				}

				/// <java-name>
				/// getCellSignalStrength
				/// </java-name>
				public global::Android.Telephony.CellSignalStrengthGsm CellSignalStrength
				{
						[Dot42.DexImport("getCellSignalStrength", "()Landroid/telephony/CellSignalStrengthGsm;", AccessFlags = 1)]
						get{ return default(global::Android.Telephony.CellSignalStrengthGsm); }
				}

		}

		/// <summary>
		///  <para>Immutable cell information from a point in time. </para>    
		/// </summary>
		/// <java-name>
		/// android/telephony/CellInfoLte
		/// </java-name>
		[Dot42.DexImport("android/telephony/CellInfoLte", AccessFlags = 49)]
		public sealed partial class CellInfoLte : global::Android.Telephony.CellInfo, global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Telephony.CellInfoLte> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal CellInfoLte() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>hash code </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object other) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public override int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public override void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCellIdentity
				/// </java-name>
				public global::Android.Telephony.CellIdentityLte CellIdentity
				{
						[Dot42.DexImport("getCellIdentity", "()Landroid/telephony/CellIdentityLte;", AccessFlags = 1)]
						get{ return default(global::Android.Telephony.CellIdentityLte); }
				}

				/// <java-name>
				/// getCellSignalStrength
				/// </java-name>
				public global::Android.Telephony.CellSignalStrengthLte CellSignalStrength
				{
						[Dot42.DexImport("getCellSignalStrength", "()Landroid/telephony/CellSignalStrengthLte;", AccessFlags = 1)]
						get{ return default(global::Android.Telephony.CellSignalStrengthLte); }
				}

		}

		/// <summary>
		///  <para>Abstract class that represents the location of the device. {} </para>    
		/// </summary>
		/// <java-name>
		/// android/telephony/CellLocation
		/// </java-name>
		[Dot42.DexImport("android/telephony/CellLocation", AccessFlags = 1057)]
		public abstract partial class CellLocation
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CellLocation() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Request an update of the current location. If the location has changed, a broadcast will be sent to everyone registered with PhoneStateListener#LISTEN_CELL_LOCATION. </para>        
				/// </summary>
				/// <java-name>
				/// requestLocationUpdate
				/// </java-name>
				[Dot42.DexImport("requestLocationUpdate", "()V", AccessFlags = 9)]
				public static void RequestLocationUpdate() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return a new CellLocation object representing an unknown location, or null for unknown/none phone radio types. </para>        
				/// </summary>
				/// <java-name>
				/// getEmpty
				/// </java-name>
				public static global::Android.Telephony.CellLocation Empty
				{
						[Dot42.DexImport("getEmpty", "()Landroid/telephony/CellLocation;", AccessFlags = 9)]
						get{ return default(global::Android.Telephony.CellLocation); }
				}

		}

		/// <summary>
		///  <para>Abstract base class for cell phone signal strength related information. </para>    
		/// </summary>
		/// <java-name>
		/// android/telephony/CellSignalStrength
		/// </java-name>
		[Dot42.DexImport("android/telephony/CellSignalStrength", AccessFlags = 1057)]
		public abstract partial class CellSignalStrength
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal CellSignalStrength() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1025)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Get signal level as an int from 0..4 </para>        
				/// </summary>
				/// <java-name>
				/// getLevel
				/// </java-name>
				public abstract int Level
				{
						[Dot42.DexImport("getLevel", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Get the signal level as an asu value between 0..31, 99 is unknown </para>        
				/// </summary>
				/// <java-name>
				/// getAsuLevel
				/// </java-name>
				public abstract int AsuLevel
				{
						[Dot42.DexImport("getAsuLevel", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Get the signal strength as dBm </para>        
				/// </summary>
				/// <java-name>
				/// getDbm
				/// </java-name>
				public abstract int Dbm
				{
						[Dot42.DexImport("getDbm", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>LTE signal strength related information. </para>    
		/// </summary>
		/// <java-name>
		/// android/telephony/CellSignalStrengthCdma
		/// </java-name>
		[Dot42.DexImport("android/telephony/CellSignalStrengthCdma", AccessFlags = 49)]
		public sealed partial class CellSignalStrengthCdma : global::Android.Telephony.CellSignalStrength, global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Telephony.CellSignalStrengthCdma> CREATOR;
				/// <summary>
				///  <para>Empty constructor</para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal CellSignalStrengthCdma() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>string representation. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Get signal level as an int from 0..4 </para>        
				/// </summary>
				/// <java-name>
				/// getLevel
				/// </java-name>
				public override int Level
				{
						[Dot42.DexImport("getLevel", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Get the LTE signal level as an asu value between 0..97, 99 is unknown Asu is calculated based on 3GPP RSRP. Refer to 3GPP 27.007 (Ver 10.3.0) Sec 8.69 </para>        
				/// </summary>
				/// <java-name>
				/// getAsuLevel
				/// </java-name>
				public override int AsuLevel
				{
						[Dot42.DexImport("getAsuLevel", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Get cdma as level 0..4 </para>        
				/// </summary>
				/// <java-name>
				/// getCdmaLevel
				/// </java-name>
				public int CdmaLevel
				{
						[Dot42.DexImport("getCdmaLevel", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Get Evdo as level 0..4 </para>        
				/// </summary>
				/// <java-name>
				/// getEvdoLevel
				/// </java-name>
				public int EvdoLevel
				{
						[Dot42.DexImport("getEvdoLevel", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Get the signal strength as dBm </para>        
				/// </summary>
				/// <java-name>
				/// getDbm
				/// </java-name>
				public override int Dbm
				{
						[Dot42.DexImport("getDbm", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Get the CDMA RSSI value in dBm </para>        
				/// </summary>
				/// <java-name>
				/// getCdmaDbm
				/// </java-name>
				public int CdmaDbm
				{
						[Dot42.DexImport("getCdmaDbm", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Get the CDMA Ec/Io value in dB*10 </para>        
				/// </summary>
				/// <java-name>
				/// getCdmaEcio
				/// </java-name>
				public int CdmaEcio
				{
						[Dot42.DexImport("getCdmaEcio", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Get the EVDO RSSI value in dBm </para>        
				/// </summary>
				/// <java-name>
				/// getEvdoDbm
				/// </java-name>
				public int EvdoDbm
				{
						[Dot42.DexImport("getEvdoDbm", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Get the EVDO Ec/Io value in dB*10 </para>        
				/// </summary>
				/// <java-name>
				/// getEvdoEcio
				/// </java-name>
				public int EvdoEcio
				{
						[Dot42.DexImport("getEvdoEcio", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Get the signal to noise ratio. Valid values are 0-8. 8 is the highest. </para>        
				/// </summary>
				/// <java-name>
				/// getEvdoSnr
				/// </java-name>
				public int EvdoSnr
				{
						[Dot42.DexImport("getEvdoSnr", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>GSM signal strength related information. </para>    
		/// </summary>
		/// <java-name>
		/// android/telephony/CellSignalStrengthGsm
		/// </java-name>
		[Dot42.DexImport("android/telephony/CellSignalStrengthGsm", AccessFlags = 49)]
		public sealed partial class CellSignalStrengthGsm : global::Android.Telephony.CellSignalStrength, global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Telephony.CellSignalStrengthGsm> CREATOR;
				/// <summary>
				///  <para>Empty constructor</para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal CellSignalStrengthGsm() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>string representation. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Get signal level as an int from 0..4 </para>        
				/// </summary>
				/// <java-name>
				/// getLevel
				/// </java-name>
				public override int Level
				{
						[Dot42.DexImport("getLevel", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Get the signal strength as dBm </para>        
				/// </summary>
				/// <java-name>
				/// getDbm
				/// </java-name>
				public override int Dbm
				{
						[Dot42.DexImport("getDbm", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Get the signal level as an asu value between 0..31, 99 is unknown Asu is calculated based on 3GPP RSRP. Refer to 3GPP 27.007 (Ver 10.3.0) Sec 8.69 </para>        
				/// </summary>
				/// <java-name>
				/// getAsuLevel
				/// </java-name>
				public override int AsuLevel
				{
						[Dot42.DexImport("getAsuLevel", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>LTE signal strength related information. </para>    
		/// </summary>
		/// <java-name>
		/// android/telephony/CellSignalStrengthLte
		/// </java-name>
		[Dot42.DexImport("android/telephony/CellSignalStrengthLte", AccessFlags = 49)]
		public sealed partial class CellSignalStrengthLte : global::Android.Telephony.CellSignalStrength, global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Telephony.CellSignalStrengthLte> CREATOR;
				/// <summary>
				///  <para>Empty constructor</para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal CellSignalStrengthLte() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>string representation. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Get signal level as an int from 0..4 </para>        
				/// </summary>
				/// <java-name>
				/// getLevel
				/// </java-name>
				public override int Level
				{
						[Dot42.DexImport("getLevel", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Get signal strength as dBm </para>        
				/// </summary>
				/// <java-name>
				/// getDbm
				/// </java-name>
				public override int Dbm
				{
						[Dot42.DexImport("getDbm", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Get the LTE signal level as an asu value between 0..97, 99 is unknown Asu is calculated based on 3GPP RSRP. Refer to 3GPP 27.007 (Ver 10.3.0) Sec 8.69 </para>        
				/// </summary>
				/// <java-name>
				/// getAsuLevel
				/// </java-name>
				public override int AsuLevel
				{
						[Dot42.DexImport("getAsuLevel", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Get the timing advance value for LTE. See 3GPP xxxx </para>        
				/// </summary>
				/// <java-name>
				/// getTimingAdvance
				/// </java-name>
				public int TimingAdvance
				{
						[Dot42.DexImport("getTimingAdvance", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>Represents the neighboring cell information, including Received Signal Strength and Cell ID location. </para>    
		/// </summary>
		/// <java-name>
		/// android/telephony/NeighboringCellInfo
		/// </java-name>
		[Dot42.DexImport("android/telephony/NeighboringCellInfo", AccessFlags = 33)]
		public partial class NeighboringCellInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Signal strength is not available </para>        
				/// </summary>
				/// <java-name>
				/// UNKNOWN_RSSI
				/// </java-name>
				[Dot42.DexImport("UNKNOWN_RSSI", "I", AccessFlags = 25)]
				public const int UNKNOWN_RSSI = 99;
				/// <summary>
				///  <para>Cell location is not available </para>        
				/// </summary>
				/// <java-name>
				/// UNKNOWN_CID
				/// </java-name>
				[Dot42.DexImport("UNKNOWN_CID", "I", AccessFlags = 25)]
				public const int UNKNOWN_CID = -1;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Telephony.NeighboringCellInfo> CREATOR;
				/// <summary>
				///  <para>Empty constructor. Initializes the RSSI and CID.</para> <para>NeighboringCellInfo is one time shot for the neighboring cells based on the radio network type at that moment. Its constructor needs radio network type.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>by NeighboringCellInfo(int, String, int) </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NeighboringCellInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initialize the object from rssi and cid.</para> <para>NeighboringCellInfo is one time shot for the neighboring cells based on the radio network type at that moment. Its constructor needs radio network type.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>by NeighboringCellInfo(int, String, int) </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public NeighboringCellInfo(int rssi, int cid) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initialize the object from rssi, location string, and radioType radioType is one of following TelephonyManager.NETWORK_TYPE_GPRS, TelephonyManager.NETWORK_TYPE_EDGE, TelephonyManager.NETWORK_TYPE_UMTS, TelephonyManager.NETWORK_TYPE_HSDPA, TelephonyManager.NETWORK_TYPE_HSUPA, and TelephonyManager.NETWORK_TYPE_HSPA. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(ILjava/lang/String;I)V", AccessFlags = 1)]
				public NeighboringCellInfo(int rssi, string location, int radioType) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initialize the object from a parcel. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public NeighboringCellInfo(global::Android.OS.Parcel @in) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>For GSM, it is in "asu" ranging from 0 to 31 (dBm = -113 + 2*asu) 0 means "-113 dBm or less" and 31 means "-51 dBm or greater" For UMTS, it is the Level index of CPICH RSCP defined in TS 25.125 </para>        
				/// </summary>
				/// <returns>
				///  <para>received signal strength or UNKNOWN_RSSI if unknown</para>
				/// </returns>
				/// <java-name>
				/// getRssi
				/// </java-name>
				public virtual int Rssi
				{
						[Dot42.DexImport("getRssi", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setRssi", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>LAC in GSM, 0xffff max legal value UNKNOWN_CID if in UMTS or CMDA or unknown </para>
				/// </returns>
				/// <java-name>
				/// getLac
				/// </java-name>
				public virtual int Lac
				{
						[Dot42.DexImport("getLac", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>cell id in GSM, 0xffff max legal value UNKNOWN_CID if in UMTS or CDMA or unknown </para>
				/// </returns>
				/// <java-name>
				/// getCid
				/// </java-name>
				public virtual int Cid
				{
						[Dot42.DexImport("getCid", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setCid", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Primary Scrambling Code in 9 bits format in UMTS, 0x1ff max value UNKNOWN_CID if in GSM or CMDA or unknown </para>
				/// </returns>
				/// <java-name>
				/// getPsc
				/// </java-name>
				public virtual int Psc
				{
						[Dot42.DexImport("getPsc", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return TelephonyManager.NETWORK_TYPE_UNKNOWN means that the location information is unavailable.</para> <para>Return TelephonyManager.NETWORK_TYPE_GPRS or TelephonyManager.NETWORK_TYPE_EDGE means that Neighboring Cell information is stored for GSM network, in which NeighboringCellInfo.getLac and NeighboringCellInfo.getCid should be called to access location.</para> <para>Return TelephonyManager.NETWORK_TYPE_UMTS, TelephonyManager.NETWORK_TYPE_HSDPA, TelephonyManager.NETWORK_TYPE_HSUPA, or TelephonyManager.NETWORK_TYPE_HSPA means that Neighboring Cell information is stored for UMTS network, in which NeighboringCellInfo.getPsc should be called to access location. </para>        
				/// </summary>
				/// <returns>
				///  <para>Radio network type while neighboring cell location is stored.</para>
				/// </returns>
				/// <java-name>
				/// getNetworkType
				/// </java-name>
				public virtual int NetworkType
				{
						[Dot42.DexImport("getNetworkType", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>Watches a android.widget.TextView and if a phone number is entered will format it. </para> <para>Stop formatting when the user  <ul> <li> <para>Inputs non-dialable characters </para></li> <li> <para>Removes the separator in the middle of string. </para></li></ul></para> <para>The formatting will be restarted once the text is cleared. </para>    
		/// </summary>
		/// <java-name>
		/// android/telephony/PhoneNumberFormattingTextWatcher
		/// </java-name>
		[Dot42.DexImport("android/telephony/PhoneNumberFormattingTextWatcher", AccessFlags = 33)]
		public partial class PhoneNumberFormattingTextWatcher : global::Android.Text.ITextWatcher
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The formatting is based on the current system locale and future locale changes may not take effect on this instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PhoneNumberFormattingTextWatcher() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method is called to notify you that, within  <code>s</code>, the  <code>count</code> characters beginning at  <code>start</code> are about to be replaced by new text with length  <code>after</code>. It is an error to attempt to make changes to  <code>s</code> from this callback. </para>        
				/// </summary>
				/// <java-name>
				/// beforeTextChanged
				/// </java-name>
				[Dot42.DexImport("beforeTextChanged", "(Ljava/lang/CharSequence;III)V", AccessFlags = 1)]
				public virtual void BeforeTextChanged(global::Java.Lang.ICharSequence s, int start, int count, int after) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method is called to notify you that, within  <code>s</code>, the  <code>count</code> characters beginning at  <code>start</code> have just replaced old text that had length  <code>before</code>. It is an error to attempt to make changes to  <code>s</code> from this callback. </para>        
				/// </summary>
				/// <java-name>
				/// onTextChanged
				/// </java-name>
				[Dot42.DexImport("onTextChanged", "(Ljava/lang/CharSequence;III)V", AccessFlags = 1)]
				public virtual void OnTextChanged(global::Java.Lang.ICharSequence s, int start, int before, int count) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method is called to notify you that, somewhere within  <code>s</code>, the text has been changed. It is legitimate to make further changes to  <code>s</code> from this callback, but be careful not to get yourself into an infinite loop, because any changes you make will cause this method to be called again recursively. (You are not told where the change took place because other afterTextChanged() methods may already have made other changes and invalidated the offsets. But if you need to know here, you can use Spannable#setSpan in onTextChanged to mark your place and then look up from here where the span ended up. </para>        
				/// </summary>
				/// <java-name>
				/// afterTextChanged
				/// </java-name>
				[Dot42.DexImport("afterTextChanged", "(Landroid/text/Editable;)V", AccessFlags = 33)]
				public virtual void AfterTextChanged(global::Android.Text.IEditable s) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Various utilities for dealing with phone number strings. </para>    
		/// </summary>
		/// <java-name>
		/// android/telephony/PhoneNumberUtils
		/// </java-name>
		[Dot42.DexImport("android/telephony/PhoneNumberUtils", AccessFlags = 33)]
		public partial class PhoneNumberUtils
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// PAUSE
				/// </java-name>
				[Dot42.DexImport("PAUSE", "C", AccessFlags = 25)]
				public const char PAUSE = ',';
				/// <java-name>
				/// WAIT
				/// </java-name>
				[Dot42.DexImport("WAIT", "C", AccessFlags = 25)]
				public const char WAIT = ';';
				/// <java-name>
				/// WILD
				/// </java-name>
				[Dot42.DexImport("WILD", "C", AccessFlags = 25)]
				public const char WILD = 'N';
				/// <java-name>
				/// TOA_International
				/// </java-name>
				[Dot42.DexImport("TOA_International", "I", AccessFlags = 25)]
				public const int TOA_International = 145;
				/// <java-name>
				/// TOA_Unknown
				/// </java-name>
				[Dot42.DexImport("TOA_Unknown", "I", AccessFlags = 25)]
				public const int TOA_Unknown = 129;
				/// <summary>
				///  <para>The current locale is unknown, look for a country code or don't format </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("FORMAT_UNKNOWN", "I", AccessFlags = 25)]
				public const int FORMAT_UNKNOWN = 0;
				/// <summary>
				///  <para>NANP formatting </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_NANP
				/// </java-name>
				[Dot42.DexImport("FORMAT_NANP", "I", AccessFlags = 25)]
				public const int FORMAT_NANP = 1;
				/// <summary>
				///  <para>Japanese formatting </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_JAPAN
				/// </java-name>
				[Dot42.DexImport("FORMAT_JAPAN", "I", AccessFlags = 25)]
				public const int FORMAT_JAPAN = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PhoneNumberUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>True if c is ISO-LATIN characters 0-9 </para>        
				/// </summary>
				/// <java-name>
				/// isISODigit
				/// </java-name>
				[Dot42.DexImport("isISODigit", "(C)Z", AccessFlags = 9)]
				public static bool IsISODigit(char c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>True if c is ISO-LATIN characters 0-9, *, # </para>        
				/// </summary>
				/// <java-name>
				/// is12Key
				/// </java-name>
				[Dot42.DexImport("is12Key", "(C)Z", AccessFlags = 25)]
				public static bool Is12Key(char c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isDialable
				/// </java-name>
				[Dot42.DexImport("isDialable", "(C)Z", AccessFlags = 25)]
				public static bool IsDialable(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>True if c is ISO-LATIN characters 0-9, *, # , + (no WILD) </para>        
				/// </summary>
				/// <java-name>
				/// isReallyDialable
				/// </java-name>
				[Dot42.DexImport("isReallyDialable", "(C)Z", AccessFlags = 25)]
				public static bool IsReallyDialable(char c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isNonSeparator
				/// </java-name>
				[Dot42.DexImport("isNonSeparator", "(C)Z", AccessFlags = 25)]
				public static bool IsNonSeparator(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>This any anything to the right of this char is part of the post-dial string (eg this is PAUSE or WAIT) </para>        
				/// </summary>
				/// <java-name>
				/// isStartsPostDial
				/// </java-name>
				[Dot42.DexImport("isStartsPostDial", "(C)Z", AccessFlags = 25)]
				public static bool IsStartsPostDial(char c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Extracts the phone number from an Intent.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the phone number that would be called by the intent, or  <code>null</code> if the number cannot be found. </para>
				/// </returns>
				/// <java-name>
				/// getNumberFromIntent
				/// </java-name>
				[Dot42.DexImport("getNumberFromIntent", "(Landroid/content/Intent;Landroid/content/Context;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetNumberFromIntent(global::Android.Content.Intent intent, global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Extracts the network address portion and canonicalizes (filters out separators.) Network address portion is everything up to DTMF control digit separators (pause or wait), but without non-dialable characters.</para> <para>Please note that the GSM wild character is allowed in the result. This must be resolved before dialing.</para> <para>Returns null if phoneNumber == null </para>        
				/// </summary>
				/// <java-name>
				/// extractNetworkPortion
				/// </java-name>
				[Dot42.DexImport("extractNetworkPortion", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string ExtractNetworkPortion(string phoneNumber) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Strips separators from a phone number string. </para>        
				/// </summary>
				/// <returns>
				///  <para>phone string stripped of separators. </para>
				/// </returns>
				/// <java-name>
				/// stripSeparators
				/// </java-name>
				[Dot42.DexImport("stripSeparators", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string StripSeparators(string phoneNumber) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Extracts the post-dial sequence of DTMF control digits, pauses, and waits. Strips separators. This string may be empty, but will not be null unless phoneNumber == null.</para> <para>Returns null if phoneNumber == null </para>        
				/// </summary>
				/// <java-name>
				/// extractPostDialPortion
				/// </java-name>
				[Dot42.DexImport("extractPostDialPortion", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string ExtractPostDialPortion(string phoneNumber) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Compare phone numbers a and b, return true if they're identical enough for caller ID purposes. </para>        
				/// </summary>
				/// <java-name>
				/// compare
				/// </java-name>
				[Dot42.DexImport("compare", "(Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool Compare(string a, string b) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// compare
				/// </java-name>
				[Dot42.DexImport("compare", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool Compare(global::Android.Content.Context context, string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns the rightmost MIN_MATCH (5) characters in the network portion in *reversed* order</para> <para>This can be used to do a database lookup against the column that stores getStrippedReversed()</para> <para>Returns null if phoneNumber == null </para>        
				/// </summary>
				/// <java-name>
				/// toCallerIDMinMatch
				/// </java-name>
				[Dot42.DexImport("toCallerIDMinMatch", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToCallerIDMinMatch(string phoneNumber) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns the network portion reversed. This string is intended to go into an index column for a database lookup.</para> <para>Returns null if phoneNumber == null </para>        
				/// </summary>
				/// <java-name>
				/// getStrippedReversed
				/// </java-name>
				[Dot42.DexImport("getStrippedReversed", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetStrippedReversed(string phoneNumber) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Basically: makes sure there's a + in front of a TOA_International number</para> <para>Returns null if s == null </para>        
				/// </summary>
				/// <java-name>
				/// stringFromStringAndTOA
				/// </java-name>
				[Dot42.DexImport("stringFromStringAndTOA", "(Ljava/lang/String;I)Ljava/lang/String;", AccessFlags = 9)]
				public static string StringFromStringAndTOA(string s, int TOA) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns the TOA for the given dial string Basically, returns TOA_International if there's a + prefix </para>        
				/// </summary>
				/// <java-name>
				/// toaFromString
				/// </java-name>
				[Dot42.DexImport("toaFromString", "(Ljava/lang/String;)I", AccessFlags = 9)]
				public static int ToaFromString(string s) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>3GPP TS 24.008 10.5.4.7 Called Party BCD Number</para> <para>See Also TS 51.011 10.5.1 "dialing number/ssc string" and TS 11.11 "10.3.1 EF adn (Abbreviated dialing numbers)"</para> <para>FIXME(mkf) support alphanumeric address type currently implemented in SMSMessage.getAddress() </para>        
				/// </summary>
				/// <returns>
				///  <para>partial string on invalid decode</para>
				/// </returns>
				/// <java-name>
				/// calledPartyBCDToString
				/// </java-name>
				[Dot42.DexImport("calledPartyBCDToString", "([BII)Ljava/lang/String;", AccessFlags = 9)]
				public static string CalledPartyBCDToString(sbyte[] bytes, int offset, int length) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>3GPP TS 24.008 10.5.4.7 Called Party BCD Number</para> <para>See Also TS 51.011 10.5.1 "dialing number/ssc string" and TS 11.11 "10.3.1 EF adn (Abbreviated dialing numbers)"</para> <para>FIXME(mkf) support alphanumeric address type currently implemented in SMSMessage.getAddress() </para>        
				/// </summary>
				/// <returns>
				///  <para>partial string on invalid decode</para>
				/// </returns>
				/// <java-name>
				/// calledPartyBCDToString
				/// </java-name>
				[Dot42.DexImport("calledPartyBCDToString", "([BII)Ljava/lang/String;", AccessFlags = 9, IgnoreFromJava = true)]
				public static string CalledPartyBCDToString(byte[] bytes, int offset, int length) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Like calledPartyBCDToString, but field does not start with a TOA byte. For example: SIM ADN extension fields </para>        
				/// </summary>
				/// <java-name>
				/// calledPartyBCDFragmentToString
				/// </java-name>
				[Dot42.DexImport("calledPartyBCDFragmentToString", "([BII)Ljava/lang/String;", AccessFlags = 9)]
				public static string CalledPartyBCDFragmentToString(sbyte[] bytes, int offset, int length) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Like calledPartyBCDToString, but field does not start with a TOA byte. For example: SIM ADN extension fields </para>        
				/// </summary>
				/// <java-name>
				/// calledPartyBCDFragmentToString
				/// </java-name>
				[Dot42.DexImport("calledPartyBCDFragmentToString", "([BII)Ljava/lang/String;", AccessFlags = 9, IgnoreFromJava = true)]
				public static string CalledPartyBCDFragmentToString(byte[] bytes, int offset, int length) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Return true iff the network portion of  <code>address</code> is, as far as we can tell on the device, suitable for use as an SMS destination address. </para>        
				/// </summary>
				/// <java-name>
				/// isWellFormedSmsAddress
				/// </java-name>
				[Dot42.DexImport("isWellFormedSmsAddress", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsWellFormedSmsAddress(string address) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isGlobalPhoneNumber
				/// </java-name>
				[Dot42.DexImport("isGlobalPhoneNumber", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsGlobalPhoneNumber(string phoneNumber) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Note: calls extractNetworkPortion(), so do not use for SIM EF[ADN] style records</para> <para>Returns null if network portion is empty. </para>        
				/// </summary>
				/// <java-name>
				/// networkPortionToCalledPartyBCD
				/// </java-name>
				[Dot42.DexImport("networkPortionToCalledPartyBCD", "(Ljava/lang/String;)[B", AccessFlags = 9)]
				public static sbyte[] JavaNetworkPortionToCalledPartyBCD(string s) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Note: calls extractNetworkPortion(), so do not use for SIM EF[ADN] style records</para> <para>Returns null if network portion is empty. </para>        
				/// </summary>
				/// <java-name>
				/// networkPortionToCalledPartyBCD
				/// </java-name>
				[Dot42.DexImport("networkPortionToCalledPartyBCD", "(Ljava/lang/String;)[B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte[] NetworkPortionToCalledPartyBCD(string s) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Same as networkPortionToCalledPartyBCD, but includes a one-byte length prefix. </para>        
				/// </summary>
				/// <java-name>
				/// networkPortionToCalledPartyBCDWithLength
				/// </java-name>
				[Dot42.DexImport("networkPortionToCalledPartyBCDWithLength", "(Ljava/lang/String;)[B", AccessFlags = 9)]
				public static sbyte[] JavaNetworkPortionToCalledPartyBCDWithLength(string s) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Same as networkPortionToCalledPartyBCD, but includes a one-byte length prefix. </para>        
				/// </summary>
				/// <java-name>
				/// networkPortionToCalledPartyBCDWithLength
				/// </java-name>
				[Dot42.DexImport("networkPortionToCalledPartyBCDWithLength", "(Ljava/lang/String;)[B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte[] NetworkPortionToCalledPartyBCDWithLength(string s) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Convert a dialing number to BCD byte array</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>BCD byte array </para>
				/// </returns>
				/// <java-name>
				/// numberToCalledPartyBCD
				/// </java-name>
				[Dot42.DexImport("numberToCalledPartyBCD", "(Ljava/lang/String;)[B", AccessFlags = 9)]
				public static sbyte[] JavaNumberToCalledPartyBCD(string number) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Convert a dialing number to BCD byte array</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>BCD byte array </para>
				/// </returns>
				/// <java-name>
				/// numberToCalledPartyBCD
				/// </java-name>
				[Dot42.DexImport("numberToCalledPartyBCD", "(Ljava/lang/String;)[B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte[] NumberToCalledPartyBCD(string number) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Breaks the given number down and formats it according to the rules for the country the number is from.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A locally acceptable formatting of the input, or the raw input if formatting rules aren't known for the number </para>
				/// </returns>
				/// <java-name>
				/// formatNumber
				/// </java-name>
				[Dot42.DexImport("formatNumber", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string FormatNumber(string source) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns the phone number formatting type for the given locale.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The formatting type for the given locale, or FORMAT_UNKNOWN if the formatting rules are not known for the given locale </para>
				/// </returns>
				/// <java-name>
				/// getFormatTypeForLocale
				/// </java-name>
				[Dot42.DexImport("getFormatTypeForLocale", "(Ljava/util/Locale;)I", AccessFlags = 9)]
				public static int GetFormatTypeForLocale(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Formats a phone number in-place. Currently FORMAT_JAPAN and FORMAT_NANP is supported as a second argument.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// formatNumber
				/// </java-name>
				[Dot42.DexImport("formatNumber", "(Landroid/text/Editable;I)V", AccessFlags = 9)]
				public static void FormatNumber(global::Android.Text.IEditable text, int defaultFormattingType) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Formats a phone number in-place using the NANP formatting rules. Numbers will be formatted as:</para> <para> <code> xxxxx xxx-xxxx xxx-xxx-xxxx 1-xxx-xxx-xxxx +1-xxx-xxx-xxxx </code></para> <para></para>        
				/// </summary>
				/// <java-name>
				/// formatNanpNumber
				/// </java-name>
				[Dot42.DexImport("formatNanpNumber", "(Landroid/text/Editable;)V", AccessFlags = 9)]
				public static void FormatNanpNumber(global::Android.Text.IEditable text) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Formats a phone number in-place using the Japanese formatting rules. Numbers will be formatted as:</para> <para> <code> 03-xxxx-xxxx 090-xxxx-xxxx 0120-xxx-xxx +81-3-xxxx-xxxx +81-90-xxxx-xxxx </code></para> <para></para>        
				/// </summary>
				/// <java-name>
				/// formatJapaneseNumber
				/// </java-name>
				[Dot42.DexImport("formatJapaneseNumber", "(Landroid/text/Editable;)V", AccessFlags = 9)]
				public static void FormatJapaneseNumber(global::Android.Text.IEditable text) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Checks a given number against the list of emergency numbers provided by the RIL and SIM card.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the number is in the list of emergency numbers listed in the RIL / SIM, otherwise return false. </para>
				/// </returns>
				/// <java-name>
				/// isEmergencyNumber
				/// </java-name>
				[Dot42.DexImport("isEmergencyNumber", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsEmergencyNumber(string number) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Translates any alphabetic letters (i.e. [A-Za-z]) in the specified phone number into the equivalent numeric digits, according to the phone keypad letter mapping described in ITU E.161 and ISO/IEC 9995-8.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the input string, with alpha letters converted to numeric digits using the phone keypad letter mapping. For example, an input of "1-800-GOOG-411" will return "1-800-4664-411". </para>
				/// </returns>
				/// <java-name>
				/// convertKeypadLettersToDigits
				/// </java-name>
				[Dot42.DexImport("convertKeypadLettersToDigits", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string ConvertKeypadLettersToDigits(string input) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		///  <para>A listener class for monitoring changes in specific telephony states on the device, including service state, signal strength, message waiting indicator (voicemail), and others. </para> <para>Override the methods for the state that you wish to receive updates for, and pass your PhoneStateListener object, along with bitwise-or of the LISTEN_ flags to TelephonyManager.listen(). </para> <para>Note that access to some telephony information is permission-protected. Your application won't receive updates for protected information unless it has the appropriate permissions declared in its manifest file. Where permissions apply, they are noted in the appropriate LISTEN_ flags. </para>    
		/// </summary>
		/// <java-name>
		/// android/telephony/PhoneStateListener
		/// </java-name>
		[Dot42.DexImport("android/telephony/PhoneStateListener", AccessFlags = 33)]
		public partial class PhoneStateListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Stop listening for updates. </para>        
				/// </summary>
				/// <java-name>
				/// LISTEN_NONE
				/// </java-name>
				[Dot42.DexImport("LISTEN_NONE", "I", AccessFlags = 25)]
				public const int LISTEN_NONE = 0;
				/// <summary>
				///  <para>Listen for changes to the network service state (cellular).</para> <para> <para>onServiceStateChanged </para> <para>ServiceState </para></para>        
				/// </summary>
				/// <java-name>
				/// LISTEN_SERVICE_STATE
				/// </java-name>
				[Dot42.DexImport("LISTEN_SERVICE_STATE", "I", AccessFlags = 25)]
				public const int LISTEN_SERVICE_STATE = 1;
				/// <summary>
				///  <para>Listen for changes to the network signal strength (cellular). {} Requires Permission: READ_PHONE_STATE </para> <para> <para>onSignalStrengthChanged</para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>by LISTEN_SIGNAL_STRENGTHS </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// LISTEN_SIGNAL_STRENGTH
				/// </java-name>
				[Dot42.DexImport("LISTEN_SIGNAL_STRENGTH", "I", AccessFlags = 25)]
				public const int LISTEN_SIGNAL_STRENGTH = 2;
				/// <summary>
				///  <para>Listen for changes to the message-waiting indicator. {} Requires Permission: READ_PHONE_STATE </para> <para>Example: The status bar uses this to determine when to display the voicemail icon.</para> <para> <para>onMessageWaitingIndicatorChanged </para></para>        
				/// </summary>
				/// <java-name>
				/// LISTEN_MESSAGE_WAITING_INDICATOR
				/// </java-name>
				[Dot42.DexImport("LISTEN_MESSAGE_WAITING_INDICATOR", "I", AccessFlags = 25)]
				public const int LISTEN_MESSAGE_WAITING_INDICATOR = 4;
				/// <summary>
				///  <para>Listen for changes to the call-forwarding indicator. {} Requires Permission: READ_PHONE_STATE  <para>onCallForwardingIndicatorChanged </para></para>        
				/// </summary>
				/// <java-name>
				/// LISTEN_CALL_FORWARDING_INDICATOR
				/// </java-name>
				[Dot42.DexImport("LISTEN_CALL_FORWARDING_INDICATOR", "I", AccessFlags = 25)]
				public const int LISTEN_CALL_FORWARDING_INDICATOR = 8;
				/// <summary>
				///  <para>Listen for changes to the device's cell location. Note that this will result in frequent callbacks to the listener. {} Requires Permission: ACCESS_COARSE_LOCATION </para> <para>If you need regular location updates but want more control over the update interval or location precision, you can set up a listener through the location manager instead.</para> <para> <para>onCellLocationChanged </para></para>        
				/// </summary>
				/// <java-name>
				/// LISTEN_CELL_LOCATION
				/// </java-name>
				[Dot42.DexImport("LISTEN_CELL_LOCATION", "I", AccessFlags = 25)]
				public const int LISTEN_CELL_LOCATION = 16;
				/// <summary>
				///  <para>Listen for changes to the device call state. {} Requires Permission: READ_PHONE_STATE  <para>onCallStateChanged </para></para>        
				/// </summary>
				/// <java-name>
				/// LISTEN_CALL_STATE
				/// </java-name>
				[Dot42.DexImport("LISTEN_CALL_STATE", "I", AccessFlags = 25)]
				public const int LISTEN_CALL_STATE = 32;
				/// <summary>
				///  <para>Listen for changes to the data connection state (cellular).</para> <para> <para>onDataConnectionStateChanged </para></para>        
				/// </summary>
				/// <java-name>
				/// LISTEN_DATA_CONNECTION_STATE
				/// </java-name>
				[Dot42.DexImport("LISTEN_DATA_CONNECTION_STATE", "I", AccessFlags = 25)]
				public const int LISTEN_DATA_CONNECTION_STATE = 64;
				/// <summary>
				///  <para>Listen for changes to the direction of data traffic on the data connection (cellular). {} Requires Permission: READ_PHONE_STATE Example: The status bar uses this to display the appropriate data-traffic icon.</para> <para> <para>onDataActivity </para></para>        
				/// </summary>
				/// <java-name>
				/// LISTEN_DATA_ACTIVITY
				/// </java-name>
				[Dot42.DexImport("LISTEN_DATA_ACTIVITY", "I", AccessFlags = 25)]
				public const int LISTEN_DATA_ACTIVITY = 128;
				/// <summary>
				///  <para>Listen for changes to the network signal strengths (cellular). </para> <para>Example: The status bar uses this to control the signal-strength icon.</para> <para> <para>onSignalStrengthsChanged </para></para>        
				/// </summary>
				/// <java-name>
				/// LISTEN_SIGNAL_STRENGTHS
				/// </java-name>
				[Dot42.DexImport("LISTEN_SIGNAL_STRENGTHS", "I", AccessFlags = 25)]
				public const int LISTEN_SIGNAL_STRENGTHS = 256;
				/// <summary>
				///  <para>Listen for changes to observed cell info.</para> <para> <para>onCellInfoChanged </para></para>        
				/// </summary>
				/// <java-name>
				/// LISTEN_CELL_INFO
				/// </java-name>
				[Dot42.DexImport("LISTEN_CELL_INFO", "I", AccessFlags = 25)]
				public const int LISTEN_CELL_INFO = 1024;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PhoneStateListener() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Callback invoked when device service state changes.</para> <para> <para>ServiceState::STATE_EMERGENCY_ONLY </para> <para>ServiceState::STATE_IN_SERVICE </para> <para>ServiceState::STATE_OUT_OF_SERVICE </para> <para>ServiceState::STATE_POWER_OFF </para></para>        
				/// </summary>
				/// <java-name>
				/// onServiceStateChanged
				/// </java-name>
				[Dot42.DexImport("onServiceStateChanged", "(Landroid/telephony/ServiceState;)V", AccessFlags = 1)]
				public virtual void OnServiceStateChanged(global::Android.Telephony.ServiceState serviceState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Callback invoked when network signal strength changes.</para> <para> <para>ServiceState::STATE_EMERGENCY_ONLY </para> <para>ServiceState::STATE_IN_SERVICE </para> <para>ServiceState::STATE_OUT_OF_SERVICE </para> <para>ServiceState::STATE_POWER_OFF </para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use onSignalStrengthsChanged(SignalStrength) </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// onSignalStrengthChanged
				/// </java-name>
				[Dot42.DexImport("onSignalStrengthChanged", "(I)V", AccessFlags = 1)]
				public virtual void OnSignalStrengthChanged(int asu) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Callback invoked when the message-waiting indicator changes. </para>        
				/// </summary>
				/// <java-name>
				/// onMessageWaitingIndicatorChanged
				/// </java-name>
				[Dot42.DexImport("onMessageWaitingIndicatorChanged", "(Z)V", AccessFlags = 1)]
				public virtual void OnMessageWaitingIndicatorChanged(bool mwi) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Callback invoked when the call-forwarding indicator changes. </para>        
				/// </summary>
				/// <java-name>
				/// onCallForwardingIndicatorChanged
				/// </java-name>
				[Dot42.DexImport("onCallForwardingIndicatorChanged", "(Z)V", AccessFlags = 1)]
				public virtual void OnCallForwardingIndicatorChanged(bool cfi) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Callback invoked when device cell location changes. </para>        
				/// </summary>
				/// <java-name>
				/// onCellLocationChanged
				/// </java-name>
				[Dot42.DexImport("onCellLocationChanged", "(Landroid/telephony/CellLocation;)V", AccessFlags = 1)]
				public virtual void OnCellLocationChanged(global::Android.Telephony.CellLocation location) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Callback invoked when device call state changes.</para> <para> <para>TelephonyManager::CALL_STATE_IDLE </para> <para>TelephonyManager::CALL_STATE_RINGING </para> <para>TelephonyManager::CALL_STATE_OFFHOOK </para></para>        
				/// </summary>
				/// <java-name>
				/// onCallStateChanged
				/// </java-name>
				[Dot42.DexImport("onCallStateChanged", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public virtual void OnCallStateChanged(int state, string incomingNumber) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Callback invoked when connection state changes.</para> <para> <para>TelephonyManager::DATA_DISCONNECTED </para> <para>TelephonyManager::DATA_CONNECTING </para> <para>TelephonyManager::DATA_CONNECTED </para> <para>TelephonyManager::DATA_SUSPENDED </para></para>        
				/// </summary>
				/// <java-name>
				/// onDataConnectionStateChanged
				/// </java-name>
				[Dot42.DexImport("onDataConnectionStateChanged", "(I)V", AccessFlags = 1)]
				public virtual void OnDataConnectionStateChanged(int state) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>same as above, but with the network type. Both called. </para>        
				/// </summary>
				/// <java-name>
				/// onDataConnectionStateChanged
				/// </java-name>
				[Dot42.DexImport("onDataConnectionStateChanged", "(II)V", AccessFlags = 1)]
				public virtual void OnDataConnectionStateChanged(int state, int networkType) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Callback invoked when data activity state changes.</para> <para> <para>TelephonyManager::DATA_ACTIVITY_NONE </para> <para>TelephonyManager::DATA_ACTIVITY_IN </para> <para>TelephonyManager::DATA_ACTIVITY_OUT </para> <para>TelephonyManager::DATA_ACTIVITY_INOUT </para> <para>TelephonyManager::DATA_ACTIVITY_DORMANT </para></para>        
				/// </summary>
				/// <java-name>
				/// onDataActivity
				/// </java-name>
				[Dot42.DexImport("onDataActivity", "(I)V", AccessFlags = 1)]
				public virtual void OnDataActivity(int direction) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Callback invoked when network signal strengths changes.</para> <para> <para>ServiceState::STATE_EMERGENCY_ONLY </para> <para>ServiceState::STATE_IN_SERVICE </para> <para>ServiceState::STATE_OUT_OF_SERVICE </para> <para>ServiceState::STATE_POWER_OFF </para></para>        
				/// </summary>
				/// <java-name>
				/// onSignalStrengthsChanged
				/// </java-name>
				[Dot42.DexImport("onSignalStrengthsChanged", "(Landroid/telephony/SignalStrength;)V", AccessFlags = 1)]
				public virtual void OnSignalStrengthsChanged(global::Android.Telephony.SignalStrength signalStrength) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Callback invoked when a observed cell info has changed, or new cells have been added or removed. </para>        
				/// </summary>
				/// <java-name>
				/// onCellInfoChanged
				/// </java-name>
				[Dot42.DexImport("onCellInfoChanged", "(Ljava/util/List;)V", AccessFlags = 1, Signature = "(Ljava/util/List<Landroid/telephony/CellInfo;>;)V")]
				public virtual void OnCellInfoChanged(global::Java.Util.IList<global::Android.Telephony.CellInfo> cellInfo) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Contains phone state and service related information.</para> <para>The following phone information is included in returned ServiceState:</para> <para> <ul> <li> <para>Service state: IN_SERVICE, OUT_OF_SERVICE, EMERGENCY_ONLY, POWER_OFF </para></li> <li> <para>Roaming indicator </para></li> <li> <para>Operator name, short name and numeric id </para></li> <li> <para>Network selection mode </para></li></ul></para>    
		/// </summary>
		/// <java-name>
		/// android/telephony/ServiceState
		/// </java-name>
		[Dot42.DexImport("android/telephony/ServiceState", AccessFlags = 33)]
		public partial class ServiceState : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Normal operation condition, the phone is registered with an operator either in home network or in roaming. </para>        
				/// </summary>
				/// <java-name>
				/// STATE_IN_SERVICE
				/// </java-name>
				[Dot42.DexImport("STATE_IN_SERVICE", "I", AccessFlags = 25)]
				public const int STATE_IN_SERVICE = 0;
				/// <summary>
				///  <para>Phone is not registered with any operator, the phone can be currently searching a new operator to register to, or not searching to registration at all, or registration is denied, or radio signal is not available. </para>        
				/// </summary>
				/// <java-name>
				/// STATE_OUT_OF_SERVICE
				/// </java-name>
				[Dot42.DexImport("STATE_OUT_OF_SERVICE", "I", AccessFlags = 25)]
				public const int STATE_OUT_OF_SERVICE = 1;
				/// <summary>
				///  <para>The phone is registered and locked. Only emergency numbers are allowed. {} </para>        
				/// </summary>
				/// <java-name>
				/// STATE_EMERGENCY_ONLY
				/// </java-name>
				[Dot42.DexImport("STATE_EMERGENCY_ONLY", "I", AccessFlags = 25)]
				public const int STATE_EMERGENCY_ONLY = 2;
				/// <summary>
				///  <para>Radio of telephony is explicitly powered off. </para>        
				/// </summary>
				/// <java-name>
				/// STATE_POWER_OFF
				/// </java-name>
				[Dot42.DexImport("STATE_POWER_OFF", "I", AccessFlags = 25)]
				public const int STATE_POWER_OFF = 3;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Telephony.ServiceState> CREATOR;
				/// <summary>
				///  <para>Empty constructor </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ServiceState() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copy constructors</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/telephony/ServiceState;)V", AccessFlags = 1)]
				public ServiceState(global::Android.Telephony.ServiceState s) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copy constructors</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public ServiceState(global::Android.OS.Parcel s) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copyFrom
				/// </java-name>
				[Dot42.DexImport("copyFrom", "(Landroid/telephony/ServiceState;)V", AccessFlags = 4)]
				protected internal virtual void CopyFrom(global::Android.Telephony.ServiceState s) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setStateOutOfService
				/// </java-name>
				[Dot42.DexImport("setStateOutOfService", "()V", AccessFlags = 1)]
				public virtual void SetStateOutOfService() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setStateOff
				/// </java-name>
				[Dot42.DexImport("setStateOff", "()V", AccessFlags = 1)]
				public virtual void SetStateOff() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOperatorName
				/// </java-name>
				[Dot42.DexImport("setOperatorName", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetOperatorName(string longName, string shortName, string numeric) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get current voice service state </para>        
				/// </summary>
				/// <java-name>
				/// getState
				/// </java-name>
				public virtual int State
				{
						[Dot42.DexImport("getState", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setState", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Get current roaming indicator of phone (note: not just decoding from TS 27.007 7.2)</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if TS 27.007 7.2 roaming is true and ONS is different from SPN </para>
				/// </returns>
				/// <java-name>
				/// getRoaming
				/// </java-name>
				public virtual bool Roaming
				{
						[Dot42.DexImport("getRoaming", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setRoaming", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Get current registered operator name in long alphanumeric format.</para> <para>In GSM/UMTS, long format can be up to 16 characters long. In CDMA, returns the ERI text, if set. Otherwise, returns the ONS.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>long name of operator, null if unregistered or unknown </para>
				/// </returns>
				/// <java-name>
				/// getOperatorAlphaLong
				/// </java-name>
				public virtual string OperatorAlphaLong
				{
						[Dot42.DexImport("getOperatorAlphaLong", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Get current registered operator name in short alphanumeric format.</para> <para>In GSM/UMTS, short format can be up to 8 characters long.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>short name of operator, null if unregistered or unknown </para>
				/// </returns>
				/// <java-name>
				/// getOperatorAlphaShort
				/// </java-name>
				public virtual string OperatorAlphaShort
				{
						[Dot42.DexImport("getOperatorAlphaShort", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Get current registered operator numeric id.</para> <para>In GSM/UMTS, numeric format is 3 digit country code plus 2 or 3 digit network code.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>numeric format of operator, null if unregistered or unknown </para>
				/// </returns>
				/// <java-name>
				/// getOperatorNumeric
				/// </java-name>
				public virtual string OperatorNumeric
				{
						[Dot42.DexImport("getOperatorNumeric", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Get current network selection mode.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if manual mode, false if automatic mode </para>
				/// </returns>
				/// <java-name>
				/// getIsManualSelection
				/// </java-name>
				public virtual bool IsManualSelection
				{
						[Dot42.DexImport("getIsManualSelection", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setIsManualSelection", "(Z)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>Contains phone signal strength related information. </para>    
		/// </summary>
		/// <java-name>
		/// android/telephony/SignalStrength
		/// </java-name>
		[Dot42.DexImport("android/telephony/SignalStrength", AccessFlags = 33)]
		public partial class SignalStrength : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Empty constructor</para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SignalStrength() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Parcelable#writeToParcel </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel @out, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Parcelable#describeContents </para>        
				/// </summary>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>hash code </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the signal strengths are the same </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>string representation. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Get the GSM Signal Strength, valid values are (0-31, 99) as defined in TS 27.007 8.5 </para>        
				/// </summary>
				/// <java-name>
				/// getGsmSignalStrength
				/// </java-name>
				public virtual int GsmSignalStrength
				{
						[Dot42.DexImport("getGsmSignalStrength", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Get the GSM bit error rate (0-7, 99) as defined in TS 27.007 8.5 </para>        
				/// </summary>
				/// <java-name>
				/// getGsmBitErrorRate
				/// </java-name>
				public virtual int GsmBitErrorRate
				{
						[Dot42.DexImport("getGsmBitErrorRate", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Get the CDMA RSSI value in dBm </para>        
				/// </summary>
				/// <java-name>
				/// getCdmaDbm
				/// </java-name>
				public virtual int CdmaDbm
				{
						[Dot42.DexImport("getCdmaDbm", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Get the CDMA Ec/Io value in dB*10 </para>        
				/// </summary>
				/// <java-name>
				/// getCdmaEcio
				/// </java-name>
				public virtual int CdmaEcio
				{
						[Dot42.DexImport("getCdmaEcio", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Get the EVDO RSSI value in dBm </para>        
				/// </summary>
				/// <java-name>
				/// getEvdoDbm
				/// </java-name>
				public virtual int EvdoDbm
				{
						[Dot42.DexImport("getEvdoDbm", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Get the EVDO Ec/Io value in dB*10 </para>        
				/// </summary>
				/// <java-name>
				/// getEvdoEcio
				/// </java-name>
				public virtual int EvdoEcio
				{
						[Dot42.DexImport("getEvdoEcio", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Get the signal to noise ratio. Valid values are 0-8. 8 is the highest. </para>        
				/// </summary>
				/// <java-name>
				/// getEvdoSnr
				/// </java-name>
				public virtual int EvdoSnr
				{
						[Dot42.DexImport("getEvdoSnr", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if this is for GSM </para>
				/// </returns>
				/// <java-name>
				/// isGsm
				/// </java-name>
				public virtual bool IsGsm
				{
						[Dot42.DexImport("isGsm", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>Manages SMS operations such as sending data, text, and pdu SMS messages. Get this object by calling the static method getDefault().</para> <para>For information about how to behave as the default SMS app on Android 4.4 (API level 19) and higher, see android.provider.Telephony. </para>    
		/// </summary>
		/// <java-name>
		/// android/telephony/SmsManager
		/// </java-name>
		[Dot42.DexImport("android/telephony/SmsManager", AccessFlags = 49)]
		public sealed partial class SmsManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Free space (TS 51.011 10.5.3 / 3GPP2 C.S0023 3.4.27). </para>        
				/// </summary>
				/// <java-name>
				/// STATUS_ON_ICC_FREE
				/// </java-name>
				[Dot42.DexImport("STATUS_ON_ICC_FREE", "I", AccessFlags = 25)]
				public const int STATUS_ON_ICC_FREE = 0;
				/// <summary>
				///  <para>Received and read (TS 51.011 10.5.3 / 3GPP2 C.S0023 3.4.27). </para>        
				/// </summary>
				/// <java-name>
				/// STATUS_ON_ICC_READ
				/// </java-name>
				[Dot42.DexImport("STATUS_ON_ICC_READ", "I", AccessFlags = 25)]
				public const int STATUS_ON_ICC_READ = 1;
				/// <summary>
				///  <para>Received and unread (TS 51.011 10.5.3 / 3GPP2 C.S0023 3.4.27). </para>        
				/// </summary>
				/// <java-name>
				/// STATUS_ON_ICC_UNREAD
				/// </java-name>
				[Dot42.DexImport("STATUS_ON_ICC_UNREAD", "I", AccessFlags = 25)]
				public const int STATUS_ON_ICC_UNREAD = 3;
				/// <summary>
				///  <para>Stored and sent (TS 51.011 10.5.3 / 3GPP2 C.S0023 3.4.27). </para>        
				/// </summary>
				/// <java-name>
				/// STATUS_ON_ICC_SENT
				/// </java-name>
				[Dot42.DexImport("STATUS_ON_ICC_SENT", "I", AccessFlags = 25)]
				public const int STATUS_ON_ICC_SENT = 5;
				/// <summary>
				///  <para>Stored and unsent (TS 51.011 10.5.3 / 3GPP2 C.S0023 3.4.27). </para>        
				/// </summary>
				/// <java-name>
				/// STATUS_ON_ICC_UNSENT
				/// </java-name>
				[Dot42.DexImport("STATUS_ON_ICC_UNSENT", "I", AccessFlags = 25)]
				public const int STATUS_ON_ICC_UNSENT = 7;
				/// <summary>
				///  <para>Generic failure cause </para>        
				/// </summary>
				/// <java-name>
				/// RESULT_ERROR_GENERIC_FAILURE
				/// </java-name>
				[Dot42.DexImport("RESULT_ERROR_GENERIC_FAILURE", "I", AccessFlags = 25)]
				public const int RESULT_ERROR_GENERIC_FAILURE = 1;
				/// <summary>
				///  <para>Failed because radio was explicitly turned off </para>        
				/// </summary>
				/// <java-name>
				/// RESULT_ERROR_RADIO_OFF
				/// </java-name>
				[Dot42.DexImport("RESULT_ERROR_RADIO_OFF", "I", AccessFlags = 25)]
				public const int RESULT_ERROR_RADIO_OFF = 2;
				/// <summary>
				///  <para>Failed because no pdu provided </para>        
				/// </summary>
				/// <java-name>
				/// RESULT_ERROR_NULL_PDU
				/// </java-name>
				[Dot42.DexImport("RESULT_ERROR_NULL_PDU", "I", AccessFlags = 25)]
				public const int RESULT_ERROR_NULL_PDU = 3;
				/// <summary>
				///  <para>Failed because service is currently unavailable </para>        
				/// </summary>
				/// <java-name>
				/// RESULT_ERROR_NO_SERVICE
				/// </java-name>
				[Dot42.DexImport("RESULT_ERROR_NO_SERVICE", "I", AccessFlags = 25)]
				public const int RESULT_ERROR_NO_SERVICE = 4;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SmsManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Send a text based SMS.</para> <para> <b>Note:</b> Using this method requires that your app has the android.Manifest.permission#SEND_SMS permission.</para> <para> <b>Note:</b> Beginning with Android 4.4 (API level 19), if  <b>and only if</b> an app is not selected as the default SMS app, the system automatically writes messages sent using this method to the SMS Provider (the default SMS app is always responsible for writing its sent messages to the SMS Provider). For information about how to behave as the default SMS app, see android.provider.Telephony.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// sendTextMessage
				/// </java-name>
				[Dot42.DexImport("sendTextMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/app/PendingIntent" +
    ";Landroid/app/PendingIntent;)V", AccessFlags = 1)]
				public void SendTextMessage(string destinationAddress, string scAddress, string text, global::Android.App.PendingIntent sentIntent, global::Android.App.PendingIntent deliveryIntent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Divide a message text into several fragments, none bigger than the maximum SMS message size.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an  <code>ArrayList</code> of strings that, in order, comprise the original message</para>
				/// </returns>
				/// <java-name>
				/// divideMessage
				/// </java-name>
				[Dot42.DexImport("divideMessage", "(Ljava/lang/String;)Ljava/util/ArrayList;", AccessFlags = 1, Signature = "(Ljava/lang/String;)Ljava/util/ArrayList<Ljava/lang/String;>;")]
				public global::Java.Util.ArrayList<string> DivideMessage(string text) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<string>);
				}

				/// <summary>
				///  <para>Send a multi-part text based SMS. The callee should have already divided the message into correctly sized parts by calling  <code>divideMessage</code>.</para> <para> <b>Note:</b> Using this method requires that your app has the android.Manifest.permission#SEND_SMS permission.</para> <para> <b>Note:</b> Beginning with Android 4.4 (API level 19), if  <b>and only if</b> an app is not selected as the default SMS app, the system automatically writes messages sent using this method to the SMS Provider (the default SMS app is always responsible for writing its sent messages to the SMS Provider). For information about how to behave as the default SMS app, see android.provider.Telephony.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// sendMultipartTextMessage
				/// </java-name>
				[Dot42.DexImport("sendMultipartTextMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Lj" +
    "ava/util/ArrayList;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/lang/String;Ljava/util/ArrayList<Ljava/lang/String;>;Lja" +
    "va/util/ArrayList<Landroid/app/PendingIntent;>;Ljava/util/ArrayList<Landroid/app" +
    "/PendingIntent;>;)V")]
				public void SendMultipartTextMessage(string destinationAddress, string scAddress, global::Java.Util.ArrayList<string> parts, global::Java.Util.ArrayList<global::Android.App.PendingIntent> sentIntents, global::Java.Util.ArrayList<global::Android.App.PendingIntent> deliveryIntents) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Send a data based SMS to a specific application port.</para> <para> <b>Note:</b> Using this method requires that your app has the android.Manifest.permission#SEND_SMS permission.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// sendDataMessage
				/// </java-name>
				[Dot42.DexImport("sendDataMessage", "(Ljava/lang/String;Ljava/lang/String;S[BLandroid/app/PendingIntent;Landroid/app/P" +
    "endingIntent;)V", AccessFlags = 1)]
				public void SendDataMessage(string destinationAddress, string scAddress, short destinationPort, sbyte[] data, global::Android.App.PendingIntent sentIntent, global::Android.App.PendingIntent deliveryIntent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Send a data based SMS to a specific application port.</para> <para> <b>Note:</b> Using this method requires that your app has the android.Manifest.permission#SEND_SMS permission.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// sendDataMessage
				/// </java-name>
				[Dot42.DexImport("sendDataMessage", "(Ljava/lang/String;Ljava/lang/String;S[BLandroid/app/PendingIntent;Landroid/app/P" +
    "endingIntent;)V", AccessFlags = 1, IgnoreFromJava = true)]
				public void SendDataMessage(string destinationAddress, string scAddress, short destinationPort, byte[] data, global::Android.App.PendingIntent sentIntent, global::Android.App.PendingIntent deliveryIntent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get the default instance of the SmsManager</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the default instance of the SmsManager </para>
				/// </returns>
				/// <java-name>
				/// getDefault
				/// </java-name>
				public static global::Android.Telephony.SmsManager Default
				{
						[Dot42.DexImport("getDefault", "()Landroid/telephony/SmsManager;", AccessFlags = 9)]
						get{ return default(global::Android.Telephony.SmsManager); }
				}

		}

		/// <summary>
		///  <para>A Short Message Service message.  <para>android.provider.Telephony.Sms.Intents::getMessagesFromIntent </para></para>    
		/// </summary>
		/// <java-name>
		/// android/telephony/SmsMessage
		/// </java-name>
		[Dot42.DexImport("android/telephony/SmsMessage", AccessFlags = 33)]
		public partial class SmsMessage
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>User data text encoding code unit size </para>        
				/// </summary>
				/// <java-name>
				/// ENCODING_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("ENCODING_UNKNOWN", "I", AccessFlags = 25)]
				public const int ENCODING_UNKNOWN = 0;
				/// <java-name>
				/// ENCODING_7BIT
				/// </java-name>
				[Dot42.DexImport("ENCODING_7BIT", "I", AccessFlags = 25)]
				public const int ENCODING_7BIT = 1;
				/// <java-name>
				/// ENCODING_8BIT
				/// </java-name>
				[Dot42.DexImport("ENCODING_8BIT", "I", AccessFlags = 25)]
				public const int ENCODING_8BIT = 2;
				/// <java-name>
				/// ENCODING_16BIT
				/// </java-name>
				[Dot42.DexImport("ENCODING_16BIT", "I", AccessFlags = 25)]
				public const int ENCODING_16BIT = 3;
				/// <summary>
				///  <para>The maximum number of payload bytes per message </para>        
				/// </summary>
				/// <java-name>
				/// MAX_USER_DATA_BYTES
				/// </java-name>
				[Dot42.DexImport("MAX_USER_DATA_BYTES", "I", AccessFlags = 25)]
				public const int MAX_USER_DATA_BYTES = 140;
				/// <summary>
				///  <para>The maximum number of payload bytes per message if a user data header is present. This assumes the header only contains the CONCATENATED_8_BIT_REFERENCE element. </para>        
				/// </summary>
				/// <java-name>
				/// MAX_USER_DATA_BYTES_WITH_HEADER
				/// </java-name>
				[Dot42.DexImport("MAX_USER_DATA_BYTES_WITH_HEADER", "I", AccessFlags = 25)]
				public const int MAX_USER_DATA_BYTES_WITH_HEADER = 134;
				/// <summary>
				///  <para>The maximum number of payload septets per message </para>        
				/// </summary>
				/// <java-name>
				/// MAX_USER_DATA_SEPTETS
				/// </java-name>
				[Dot42.DexImport("MAX_USER_DATA_SEPTETS", "I", AccessFlags = 25)]
				public const int MAX_USER_DATA_SEPTETS = 160;
				/// <summary>
				///  <para>The maximum number of payload septets per message if a user data header is present. This assumes the header only contains the CONCATENATED_8_BIT_REFERENCE element. </para>        
				/// </summary>
				/// <java-name>
				/// MAX_USER_DATA_SEPTETS_WITH_HEADER
				/// </java-name>
				[Dot42.DexImport("MAX_USER_DATA_SEPTETS_WITH_HEADER", "I", AccessFlags = 25)]
				public const int MAX_USER_DATA_SEPTETS_WITH_HEADER = 153;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SmsMessage() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create an SmsMessage from a raw PDU.</para> <para> <b>This method will soon be deprecated</b> and all applications which handle incoming SMS messages by processing the <c>SMS_RECEIVED_ACTION </c> broadcast intent  <b>must</b> now pass the new <c>format </c> String extra from the intent into the new method <c>createFromPdu(byte[], String) </c> which takes an extra format parameter. This is required in order to correctly decode the PDU on devices that require support for both 3GPP and 3GPP2 formats at the same time, such as dual-mode GSM/CDMA and CDMA/LTE phones. Guess format based on Voice technology first, if it fails use other format. </para>        
				/// </summary>
				/// <java-name>
				/// createFromPdu
				/// </java-name>
				[Dot42.DexImport("createFromPdu", "([B)Landroid/telephony/SmsMessage;", AccessFlags = 9)]
				public static global::Android.Telephony.SmsMessage CreateFromPdu(sbyte[] pdu) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Telephony.SmsMessage);
				}

				/// <summary>
				///  <para>Create an SmsMessage from a raw PDU.</para> <para> <b>This method will soon be deprecated</b> and all applications which handle incoming SMS messages by processing the <c>SMS_RECEIVED_ACTION </c> broadcast intent  <b>must</b> now pass the new <c>format </c> String extra from the intent into the new method <c>createFromPdu(byte[], String) </c> which takes an extra format parameter. This is required in order to correctly decode the PDU on devices that require support for both 3GPP and 3GPP2 formats at the same time, such as dual-mode GSM/CDMA and CDMA/LTE phones. Guess format based on Voice technology first, if it fails use other format. </para>        
				/// </summary>
				/// <java-name>
				/// createFromPdu
				/// </java-name>
				[Dot42.DexImport("createFromPdu", "([B)Landroid/telephony/SmsMessage;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Android.Telephony.SmsMessage CreateFromPdu(byte[] pdu) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Telephony.SmsMessage);
				}

				/// <summary>
				///  <para>Get the TP-Layer-Length for the given SMS-SUBMIT PDU Basically, the length in bytes (not hex chars) less the SMSC header</para> <para>FIXME: This method is only used by a CTS test case that isn't run on CDMA devices. We should probably deprecate it and remove the obsolete test case. </para>        
				/// </summary>
				/// <java-name>
				/// getTPLayerLengthForPDU
				/// </java-name>
				[Dot42.DexImport("getTPLayerLengthForPDU", "(Ljava/lang/String;)I", AccessFlags = 9)]
				public static int GetTPLayerLengthForPDU(string pdu) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// calculateLength
				/// </java-name>
				[Dot42.DexImport("calculateLength", "(Ljava/lang/CharSequence;Z)[I", AccessFlags = 9)]
				public static int[] CalculateLength(global::Java.Lang.ICharSequence charSequence, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// calculateLength
				/// </java-name>
				[Dot42.DexImport("calculateLength", "(Ljava/lang/String;Z)[I", AccessFlags = 9)]
				public static int[] CalculateLength(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <summary>
				///  <para>Get an SMS-SUBMIT PDU for a destination address and a message. This method will not attempt to use any GSM national language 7 bit encodings.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a  <code>SubmitPdu</code> containing the encoded SC address, if applicable, and the encoded message. Returns null on encode error. </para>
				/// </returns>
				/// <java-name>
				/// getSubmitPdu
				/// </java-name>
				[Dot42.DexImport("getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Landroid/telephony/SmsMe" +
    "ssage$SubmitPdu;", AccessFlags = 9)]
				public static global::Android.Telephony.SmsMessage.SubmitPdu GetSubmitPdu(string scAddress, string destinationAddress, string message, bool statusReportRequested) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Telephony.SmsMessage.SubmitPdu);
				}

				/// <summary>
				///  <para>Get an SMS-SUBMIT PDU for a data message to a destination address &amp; port. This method will not attempt to use any GSM national language 7 bit encodings.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a  <code>SubmitPdu</code> containing the encoded SC address, if applicable, and the encoded message. Returns null on encode error. </para>
				/// </returns>
				/// <java-name>
				/// getSubmitPdu
				/// </java-name>
				[Dot42.DexImport("getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;S[BZ)Landroid/telephony/SmsMessage$SubmitPdu" +
    ";", AccessFlags = 9)]
				public static global::Android.Telephony.SmsMessage.SubmitPdu GetSubmitPdu(string scAddress, string destinationAddress, short destinationPort, sbyte[] data, bool statusReportRequested) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Telephony.SmsMessage.SubmitPdu);
				}

				/// <summary>
				///  <para>Get an SMS-SUBMIT PDU for a data message to a destination address &amp; port. This method will not attempt to use any GSM national language 7 bit encodings.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a  <code>SubmitPdu</code> containing the encoded SC address, if applicable, and the encoded message. Returns null on encode error. </para>
				/// </returns>
				/// <java-name>
				/// getSubmitPdu
				/// </java-name>
				[Dot42.DexImport("getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;S[BZ)Landroid/telephony/SmsMessage$SubmitPdu" +
    ";", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Android.Telephony.SmsMessage.SubmitPdu GetSubmitPdu(string scAddress, string destinationAddress, short destinationPort, byte[] data, bool statusReportRequested) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Telephony.SmsMessage.SubmitPdu);
				}

				/// <summary>
				///  <para>Returns the class of this message. </para>        
				/// </summary>
				/// <java-name>
				/// getMessageClass
				/// </java-name>
				[Dot42.DexImport("getMessageClass", "()Landroid/telephony/SmsMessage$MessageClass;", AccessFlags = 1)]
				public virtual global::Android.Telephony.SmsMessage.MessageClass GetMessageClass() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Telephony.SmsMessage.MessageClass);
				}

				/// <summary>
				///  <para>returns the user data section minus the user data header if one was present. </para>        
				/// </summary>
				/// <java-name>
				/// getUserData
				/// </java-name>
				[Dot42.DexImport("getUserData", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetUserData() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Returns the raw PDU for the message.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the raw PDU for the message. </para>
				/// </returns>
				/// <java-name>
				/// getPdu
				/// </java-name>
				[Dot42.DexImport("getPdu", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetPdu() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Returns the address of the SMS service center that relayed this message or null if there is none. </para>        
				/// </summary>
				/// <java-name>
				/// getServiceCenterAddress
				/// </java-name>
				public virtual string ServiceCenterAddress
				{
						[Dot42.DexImport("getServiceCenterAddress", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the originating address (sender) of this SMS message in String form or null if unavailable </para>        
				/// </summary>
				/// <java-name>
				/// getOriginatingAddress
				/// </java-name>
				public virtual string OriginatingAddress
				{
						[Dot42.DexImport("getOriginatingAddress", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the originating address, or email from address if this message was from an email gateway. Returns null if originating address unavailable. </para>        
				/// </summary>
				/// <java-name>
				/// getDisplayOriginatingAddress
				/// </java-name>
				public virtual string DisplayOriginatingAddress
				{
						[Dot42.DexImport("getDisplayOriginatingAddress", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the message body as a String, if it exists and is text based. </para>        
				/// </summary>
				/// <returns>
				///  <para>message body is there is one, otherwise null </para>
				/// </returns>
				/// <java-name>
				/// getMessageBody
				/// </java-name>
				public virtual string MessageBody
				{
						[Dot42.DexImport("getMessageBody", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the message body, or email message body if this message was from an email gateway. Returns null if message body unavailable. </para>        
				/// </summary>
				/// <java-name>
				/// getDisplayMessageBody
				/// </java-name>
				public virtual string DisplayMessageBody
				{
						[Dot42.DexImport("getDisplayMessageBody", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Unofficial convention of a subject line enclosed in parens empty string if not present </para>        
				/// </summary>
				/// <java-name>
				/// getPseudoSubject
				/// </java-name>
				public virtual string PseudoSubject
				{
						[Dot42.DexImport("getPseudoSubject", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the service centre timestamp in currentTimeMillis() format </para>        
				/// </summary>
				/// <java-name>
				/// getTimestampMillis
				/// </java-name>
				public virtual long TimestampMillis
				{
						[Dot42.DexImport("getTimestampMillis", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Returns true if message is an email.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if this message came through an email gateway and email sender / subject / parsed body are available </para>
				/// </returns>
				/// <java-name>
				/// isEmail
				/// </java-name>
				public virtual bool IsEmail
				{
						[Dot42.DexImport("isEmail", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>if isEmail() is true, body of the email sent through the gateway. null otherwise </para>
				/// </returns>
				/// <java-name>
				/// getEmailBody
				/// </java-name>
				public virtual string EmailBody
				{
						[Dot42.DexImport("getEmailBody", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>if isEmail() is true, email from address of email sent through the gateway. null otherwise </para>
				/// </returns>
				/// <java-name>
				/// getEmailFrom
				/// </java-name>
				public virtual string EmailFrom
				{
						[Dot42.DexImport("getEmailFrom", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Get protocol identifier. </para>        
				/// </summary>
				/// <java-name>
				/// getProtocolIdentifier
				/// </java-name>
				public virtual int ProtocolIdentifier
				{
						[Dot42.DexImport("getProtocolIdentifier", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>See TS 23.040 9.2.3.9 returns true if this is a "replace short message" SMS </para>        
				/// </summary>
				/// <java-name>
				/// isReplace
				/// </java-name>
				public virtual bool IsReplace
				{
						[Dot42.DexImport("isReplace", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns true for CPHS MWI toggle message.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if this is a CPHS MWI toggle message See CPHS 4.2 section B.4.2 </para>
				/// </returns>
				/// <java-name>
				/// isCphsMwiMessage
				/// </java-name>
				public virtual bool IsCphsMwiMessage
				{
						[Dot42.DexImport("isCphsMwiMessage", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>returns true if this message is a CPHS voicemail / message waiting indicator (MWI) clear message </para>        
				/// </summary>
				/// <java-name>
				/// isMWIClearMessage
				/// </java-name>
				public virtual bool IsMWIClearMessage
				{
						[Dot42.DexImport("isMWIClearMessage", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>returns true if this message is a CPHS voicemail / message waiting indicator (MWI) set message </para>        
				/// </summary>
				/// <java-name>
				/// isMWISetMessage
				/// </java-name>
				public virtual bool IsMWISetMessage
				{
						[Dot42.DexImport("isMWISetMessage", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>returns true if this message is a "Message Waiting Indication Group:Discard Message" notification and should not be stored. </para>        
				/// </summary>
				/// <java-name>
				/// isMwiDontStore
				/// </java-name>
				public virtual bool IsMwiDontStore
				{
						[Dot42.DexImport("isMwiDontStore", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>returns the user data section minus the user data header if one was present. </para>        
				/// </summary>
				/// <java-name>
				/// getUserData
				/// </java-name>
				public virtual byte[] UserData
				{
						[Dot42.DexImport("getUserData", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

				/// <summary>
				///  <para>Returns the raw PDU for the message.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the raw PDU for the message. </para>
				/// </returns>
				/// <java-name>
				/// getPdu
				/// </java-name>
				public virtual byte[] Pdu
				{
						[Dot42.DexImport("getPdu", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

				/// <summary>
				///  <para>Returns the status of the message on the SIM (read, unread, sent, unsent).</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getStatusOnIcc instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>the status of the message on the SIM. These are: SmsManager.STATUS_ON_SIM_FREE SmsManager.STATUS_ON_SIM_READ SmsManager.STATUS_ON_SIM_UNREAD SmsManager.STATUS_ON_SIM_SEND SmsManager.STATUS_ON_SIM_UNSENT </para>
				/// </returns>
				/// <java-name>
				/// getStatusOnSim
				/// </java-name>
				public virtual int StatusOnSim
				{
						[Dot42.DexImport("getStatusOnSim", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the status of the message on the ICC (read, unread, sent, unsent).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the status of the message on the ICC. These are: SmsManager.STATUS_ON_ICC_FREE SmsManager.STATUS_ON_ICC_READ SmsManager.STATUS_ON_ICC_UNREAD SmsManager.STATUS_ON_ICC_SEND SmsManager.STATUS_ON_ICC_UNSENT </para>
				/// </returns>
				/// <java-name>
				/// getStatusOnIcc
				/// </java-name>
				public virtual int StatusOnIcc
				{
						[Dot42.DexImport("getStatusOnIcc", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the record index of the message on the SIM (1-based index).  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getIndexOnIcc instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>the record index of the message on the SIM, or -1 if this SmsMessage was not created from a SIM SMS EF record. </para>
				/// </returns>
				/// <java-name>
				/// getIndexOnSim
				/// </java-name>
				public virtual int IndexOnSim
				{
						[Dot42.DexImport("getIndexOnSim", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the record index of the message on the ICC (1-based index). </para>        
				/// </summary>
				/// <returns>
				///  <para>the record index of the message on the ICC, or -1 if this SmsMessage was not created from a ICC SMS EF record. </para>
				/// </returns>
				/// <java-name>
				/// getIndexOnIcc
				/// </java-name>
				public virtual int IndexOnIcc
				{
						[Dot42.DexImport("getIndexOnIcc", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>GSM: For an SMS-STATUS-REPORT message, this returns the status field from the status report. This field indicates the status of a previously submitted SMS, if requested. See TS 23.040, 9.2.3.15 TP-Status for a description of values. CDMA: For not interfering with status codes from GSM, the value is shifted to the bits 31-16. The value is composed of an error class (bits 25-24) and a status code (bits 23-16). Possible codes are described in C.S0015-B, v2.0, 4.5.21.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>0 indicates the previously sent message was received. See TS 23.040, 9.9.2.3.15 and C.S0015-B, v2.0, 4.5.21 for a description of other possible values. </para>
				/// </returns>
				/// <java-name>
				/// getStatus
				/// </java-name>
				public virtual int Status
				{
						[Dot42.DexImport("getStatus", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return true iff the message is a SMS-STATUS-REPORT message. </para>        
				/// </summary>
				/// <java-name>
				/// isStatusReportMessage
				/// </java-name>
				public virtual bool IsStatusReportMessage
				{
						[Dot42.DexImport("isStatusReportMessage", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns true iff the  <code>TP-Reply-Path</code> bit is set in this message. </para>        
				/// </summary>
				/// <java-name>
				/// isReplyPathPresent
				/// </java-name>
				public virtual bool IsReplyPathPresent
				{
						[Dot42.DexImport("isReplyPathPresent", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// android/telephony/SmsMessage$SubmitPdu
				/// </java-name>
				[Dot42.DexImport("android/telephony/SmsMessage$SubmitPdu", AccessFlags = 9)]
				public partial class SubmitPdu
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// encodedScAddress
						/// </java-name>
						[Dot42.DexImport("encodedScAddress", "[B", AccessFlags = 1)]
						public sbyte[] EncodedScAddress;
						/// <java-name>
						/// encodedMessage
						/// </java-name>
						[Dot42.DexImport("encodedMessage", "[B", AccessFlags = 1)]
						public sbyte[] EncodedMessage;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal SubmitPdu() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// toString
						/// </java-name>
						[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
						public override string ToString() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

				}

				/// <java-name>
				/// android/telephony/SmsMessage$MessageClass
				/// </java-name>
				[Dot42.DexImport("android/telephony/SmsMessage$MessageClass", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/telephony/SmsMessage$MessageClass;>;")]
				public sealed class MessageClass
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CLASS_0
						/// </java-name>
						[Dot42.DexImport("CLASS_0", "Landroid/telephony/SmsMessage$MessageClass;", AccessFlags = 16409)]
						public static readonly MessageClass CLASS_0;
						/// <java-name>
						/// CLASS_1
						/// </java-name>
						[Dot42.DexImport("CLASS_1", "Landroid/telephony/SmsMessage$MessageClass;", AccessFlags = 16409)]
						public static readonly MessageClass CLASS_1;
						/// <java-name>
						/// CLASS_2
						/// </java-name>
						[Dot42.DexImport("CLASS_2", "Landroid/telephony/SmsMessage$MessageClass;", AccessFlags = 16409)]
						public static readonly MessageClass CLASS_2;
						/// <java-name>
						/// CLASS_3
						/// </java-name>
						[Dot42.DexImport("CLASS_3", "Landroid/telephony/SmsMessage$MessageClass;", AccessFlags = 16409)]
						public static readonly MessageClass CLASS_3;
						/// <java-name>
						/// UNKNOWN
						/// </java-name>
						[Dot42.DexImport("UNKNOWN", "Landroid/telephony/SmsMessage$MessageClass;", AccessFlags = 16409)]
						public static readonly MessageClass UNKNOWN;
						private MessageClass() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/telephony/SmsMessage$MessageClass;", AccessFlags = 9)]
						public static MessageClass[] Values() /* MethodBuilder.Create */ 
						{
								return default(MessageClass[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/telephony/SmsMessage$MessageClass;", AccessFlags = 9)]
						public static MessageClass ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(MessageClass);
						}

				}

		}

		/// <summary>
		///  <para>Provides access to information about the telephony services on the device. Applications can use the methods in this class to determine telephony services and states, as well as to access some types of subscriber information. Applications can also register a listener to receive notification of telephony state changes. </para> <para>You do not instantiate this class directly; instead, you retrieve a reference to an instance through Context.getSystemService(Context.TELEPHONY_SERVICE). </para> <para>Note that access to some telephony information is permission-protected. Your application cannot access the protected information unless it has the appropriate permissions declared in its manifest file. Where permissions apply, they are noted in the the methods through which you access the protected information. </para>    
		/// </summary>
		/// <java-name>
		/// android/telephony/TelephonyManager
		/// </java-name>
		[Dot42.DexImport("android/telephony/TelephonyManager", AccessFlags = 33)]
		public partial class TelephonyManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Broadcast intent action indicating that the call state (cellular) on the device has changed.</para> <para>The EXTRA_STATE extra indicates the new call state. If the new state is RINGING, a second extra EXTRA_INCOMING_NUMBER provides the incoming phone number as a String.</para> <para>Requires the READ_PHONE_STATE permission.</para> <para>This was a sticky broadcast in version 1.0, but it is no longer sticky. Instead, use getCallState to synchronously query the current call state.</para> <para> <para>EXTRA_STATE </para> <para>EXTRA_INCOMING_NUMBER </para> <para>getCallState </para></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_PHONE_STATE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_PHONE_STATE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PHONE_STATE_CHANGED = "android.intent.action.PHONE_STATE";
				/// <summary>
				///  <para>The lookup key used with the ACTION_PHONE_STATE_CHANGED broadcast for a String containing the new call state.</para> <para> <para>EXTRA_STATE_IDLE </para> <para>EXTRA_STATE_RINGING </para> <para>EXTRA_STATE_OFFHOOK</para></para> <para>Retrieve with android.content.Intent#getStringExtra(String). </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_STATE = "state";
				/// <summary>
				///  <para>Value used with EXTRA_STATE corresponding to CALL_STATE_IDLE. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_STATE_IDLE
				/// </java-name>
				[Dot42.DexImport("EXTRA_STATE_IDLE", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string EXTRA_STATE_IDLE;
				/// <summary>
				///  <para>Value used with EXTRA_STATE corresponding to CALL_STATE_RINGING. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_STATE_RINGING
				/// </java-name>
				[Dot42.DexImport("EXTRA_STATE_RINGING", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string EXTRA_STATE_RINGING;
				/// <summary>
				///  <para>Value used with EXTRA_STATE corresponding to CALL_STATE_OFFHOOK. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_STATE_OFFHOOK
				/// </java-name>
				[Dot42.DexImport("EXTRA_STATE_OFFHOOK", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string EXTRA_STATE_OFFHOOK;
				/// <summary>
				///  <para>The lookup key used with the ACTION_PHONE_STATE_CHANGED broadcast for a String containing the incoming phone number. Only valid when the new call state is RINGING.</para> <para>Retrieve with android.content.Intent#getStringExtra(String). </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_INCOMING_NUMBER
				/// </java-name>
				[Dot42.DexImport("EXTRA_INCOMING_NUMBER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_INCOMING_NUMBER = "incoming_number";
				/// <summary>
				///  <para>No phone radio. </para>        
				/// </summary>
				/// <java-name>
				/// PHONE_TYPE_NONE
				/// </java-name>
				[Dot42.DexImport("PHONE_TYPE_NONE", "I", AccessFlags = 25)]
				public const int PHONE_TYPE_NONE = 0;
				/// <summary>
				///  <para>Phone radio is GSM. </para>        
				/// </summary>
				/// <java-name>
				/// PHONE_TYPE_GSM
				/// </java-name>
				[Dot42.DexImport("PHONE_TYPE_GSM", "I", AccessFlags = 25)]
				public const int PHONE_TYPE_GSM = 1;
				/// <summary>
				///  <para>Phone radio is CDMA. </para>        
				/// </summary>
				/// <java-name>
				/// PHONE_TYPE_CDMA
				/// </java-name>
				[Dot42.DexImport("PHONE_TYPE_CDMA", "I", AccessFlags = 25)]
				public const int PHONE_TYPE_CDMA = 2;
				/// <summary>
				///  <para>Phone is via SIP. </para>        
				/// </summary>
				/// <java-name>
				/// PHONE_TYPE_SIP
				/// </java-name>
				[Dot42.DexImport("PHONE_TYPE_SIP", "I", AccessFlags = 25)]
				public const int PHONE_TYPE_SIP = 3;
				/// <summary>
				///  <para>Network type is unknown </para>        
				/// </summary>
				/// <java-name>
				/// NETWORK_TYPE_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_UNKNOWN", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_UNKNOWN = 0;
				/// <summary>
				///  <para>Current network is GPRS </para>        
				/// </summary>
				/// <java-name>
				/// NETWORK_TYPE_GPRS
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_GPRS", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_GPRS = 1;
				/// <summary>
				///  <para>Current network is EDGE </para>        
				/// </summary>
				/// <java-name>
				/// NETWORK_TYPE_EDGE
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_EDGE", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_EDGE = 2;
				/// <summary>
				///  <para>Current network is UMTS </para>        
				/// </summary>
				/// <java-name>
				/// NETWORK_TYPE_UMTS
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_UMTS", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_UMTS = 3;
				/// <summary>
				///  <para>Current network is CDMA: Either IS95A or IS95B </para>        
				/// </summary>
				/// <java-name>
				/// NETWORK_TYPE_CDMA
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_CDMA", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_CDMA = 4;
				/// <summary>
				///  <para>Current network is EVDO revision 0 </para>        
				/// </summary>
				/// <java-name>
				/// NETWORK_TYPE_EVDO_0
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_EVDO_0", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_EVDO_0 = 5;
				/// <summary>
				///  <para>Current network is EVDO revision A </para>        
				/// </summary>
				/// <java-name>
				/// NETWORK_TYPE_EVDO_A
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_EVDO_A", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_EVDO_A = 6;
				/// <summary>
				///  <para>Current network is 1xRTT </para>        
				/// </summary>
				/// <java-name>
				/// NETWORK_TYPE_1xRTT
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_1xRTT", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_1xRTT = 7;
				/// <summary>
				///  <para>Current network is HSDPA </para>        
				/// </summary>
				/// <java-name>
				/// NETWORK_TYPE_HSDPA
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_HSDPA", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_HSDPA = 8;
				/// <summary>
				///  <para>Current network is HSUPA </para>        
				/// </summary>
				/// <java-name>
				/// NETWORK_TYPE_HSUPA
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_HSUPA", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_HSUPA = 9;
				/// <summary>
				///  <para>Current network is HSPA </para>        
				/// </summary>
				/// <java-name>
				/// NETWORK_TYPE_HSPA
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_HSPA", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_HSPA = 10;
				/// <summary>
				///  <para>Current network is iDen </para>        
				/// </summary>
				/// <java-name>
				/// NETWORK_TYPE_IDEN
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_IDEN", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_IDEN = 11;
				/// <summary>
				///  <para>Current network is EVDO revision B </para>        
				/// </summary>
				/// <java-name>
				/// NETWORK_TYPE_EVDO_B
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_EVDO_B", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_EVDO_B = 12;
				/// <summary>
				///  <para>Current network is LTE </para>        
				/// </summary>
				/// <java-name>
				/// NETWORK_TYPE_LTE
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_LTE", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_LTE = 13;
				/// <summary>
				///  <para>Current network is eHRPD </para>        
				/// </summary>
				/// <java-name>
				/// NETWORK_TYPE_EHRPD
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_EHRPD", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_EHRPD = 14;
				/// <summary>
				///  <para>Current network is HSPA+ </para>        
				/// </summary>
				/// <java-name>
				/// NETWORK_TYPE_HSPAP
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_HSPAP", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_HSPAP = 15;
				/// <summary>
				///  <para>SIM card state: Unknown. Signifies that the SIM is in transition between states. For example, when the user inputs the SIM pin under PIN_REQUIRED state, a query for sim status returns this state before turning to SIM_STATE_READY. </para>        
				/// </summary>
				/// <java-name>
				/// SIM_STATE_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("SIM_STATE_UNKNOWN", "I", AccessFlags = 25)]
				public const int SIM_STATE_UNKNOWN = 0;
				/// <summary>
				///  <para>SIM card state: no SIM card is available in the device </para>        
				/// </summary>
				/// <java-name>
				/// SIM_STATE_ABSENT
				/// </java-name>
				[Dot42.DexImport("SIM_STATE_ABSENT", "I", AccessFlags = 25)]
				public const int SIM_STATE_ABSENT = 1;
				/// <summary>
				///  <para>SIM card state: Locked: requires the user's SIM PIN to unlock </para>        
				/// </summary>
				/// <java-name>
				/// SIM_STATE_PIN_REQUIRED
				/// </java-name>
				[Dot42.DexImport("SIM_STATE_PIN_REQUIRED", "I", AccessFlags = 25)]
				public const int SIM_STATE_PIN_REQUIRED = 2;
				/// <summary>
				///  <para>SIM card state: Locked: requires the user's SIM PUK to unlock </para>        
				/// </summary>
				/// <java-name>
				/// SIM_STATE_PUK_REQUIRED
				/// </java-name>
				[Dot42.DexImport("SIM_STATE_PUK_REQUIRED", "I", AccessFlags = 25)]
				public const int SIM_STATE_PUK_REQUIRED = 3;
				/// <summary>
				///  <para>SIM card state: Locked: requries a network PIN to unlock </para>        
				/// </summary>
				/// <java-name>
				/// SIM_STATE_NETWORK_LOCKED
				/// </java-name>
				[Dot42.DexImport("SIM_STATE_NETWORK_LOCKED", "I", AccessFlags = 25)]
				public const int SIM_STATE_NETWORK_LOCKED = 4;
				/// <summary>
				///  <para>SIM card state: Ready </para>        
				/// </summary>
				/// <java-name>
				/// SIM_STATE_READY
				/// </java-name>
				[Dot42.DexImport("SIM_STATE_READY", "I", AccessFlags = 25)]
				public const int SIM_STATE_READY = 5;
				/// <summary>
				///  <para>Device call state: No activity. </para>        
				/// </summary>
				/// <java-name>
				/// CALL_STATE_IDLE
				/// </java-name>
				[Dot42.DexImport("CALL_STATE_IDLE", "I", AccessFlags = 25)]
				public const int CALL_STATE_IDLE = 0;
				/// <summary>
				///  <para>Device call state: Ringing. A new call arrived and is ringing or waiting. In the latter case, another call is already active. </para>        
				/// </summary>
				/// <java-name>
				/// CALL_STATE_RINGING
				/// </java-name>
				[Dot42.DexImport("CALL_STATE_RINGING", "I", AccessFlags = 25)]
				public const int CALL_STATE_RINGING = 1;
				/// <summary>
				///  <para>Device call state: Off-hook. At least one call exists that is dialing, active, or on hold, and no calls are ringing or waiting. </para>        
				/// </summary>
				/// <java-name>
				/// CALL_STATE_OFFHOOK
				/// </java-name>
				[Dot42.DexImport("CALL_STATE_OFFHOOK", "I", AccessFlags = 25)]
				public const int CALL_STATE_OFFHOOK = 2;
				/// <summary>
				///  <para>Data connection activity: No traffic. </para>        
				/// </summary>
				/// <java-name>
				/// DATA_ACTIVITY_NONE
				/// </java-name>
				[Dot42.DexImport("DATA_ACTIVITY_NONE", "I", AccessFlags = 25)]
				public const int DATA_ACTIVITY_NONE = 0;
				/// <summary>
				///  <para>Data connection activity: Currently receiving IP PPP traffic. </para>        
				/// </summary>
				/// <java-name>
				/// DATA_ACTIVITY_IN
				/// </java-name>
				[Dot42.DexImport("DATA_ACTIVITY_IN", "I", AccessFlags = 25)]
				public const int DATA_ACTIVITY_IN = 1;
				/// <summary>
				///  <para>Data connection activity: Currently sending IP PPP traffic. </para>        
				/// </summary>
				/// <java-name>
				/// DATA_ACTIVITY_OUT
				/// </java-name>
				[Dot42.DexImport("DATA_ACTIVITY_OUT", "I", AccessFlags = 25)]
				public const int DATA_ACTIVITY_OUT = 2;
				/// <summary>
				///  <para>Data connection activity: Currently both sending and receiving IP PPP traffic. </para>        
				/// </summary>
				/// <java-name>
				/// DATA_ACTIVITY_INOUT
				/// </java-name>
				[Dot42.DexImport("DATA_ACTIVITY_INOUT", "I", AccessFlags = 25)]
				public const int DATA_ACTIVITY_INOUT = 3;
				/// <summary>
				///  <para>Data connection is active, but physical link is down </para>        
				/// </summary>
				/// <java-name>
				/// DATA_ACTIVITY_DORMANT
				/// </java-name>
				[Dot42.DexImport("DATA_ACTIVITY_DORMANT", "I", AccessFlags = 25)]
				public const int DATA_ACTIVITY_DORMANT = 4;
				/// <summary>
				///  <para>Data connection state: Disconnected. IP traffic not available. </para>        
				/// </summary>
				/// <java-name>
				/// DATA_DISCONNECTED
				/// </java-name>
				[Dot42.DexImport("DATA_DISCONNECTED", "I", AccessFlags = 25)]
				public const int DATA_DISCONNECTED = 0;
				/// <summary>
				///  <para>Data connection state: Currently setting up a data connection. </para>        
				/// </summary>
				/// <java-name>
				/// DATA_CONNECTING
				/// </java-name>
				[Dot42.DexImport("DATA_CONNECTING", "I", AccessFlags = 25)]
				public const int DATA_CONNECTING = 1;
				/// <summary>
				///  <para>Data connection state: Connected. IP traffic should be available. </para>        
				/// </summary>
				/// <java-name>
				/// DATA_CONNECTED
				/// </java-name>
				[Dot42.DexImport("DATA_CONNECTED", "I", AccessFlags = 25)]
				public const int DATA_CONNECTED = 2;
				/// <summary>
				///  <para>Data connection state: Suspended. The connection is up, but IP traffic is temporarily unavailable. For example, in a 2G network, data activity may be suspended when a voice call arrives. </para>        
				/// </summary>
				/// <java-name>
				/// DATA_SUSPENDED
				/// </java-name>
				[Dot42.DexImport("DATA_SUSPENDED", "I", AccessFlags = 25)]
				public const int DATA_SUSPENDED = 3;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal TelephonyManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Registers a listener object to receive notification of changes in specified telephony states. </para> <para>To register a listener, pass a PhoneStateListener and specify at least one telephony state of interest in the events argument.</para> <para>At registration, and when a specified telephony state changes, the telephony manager invokes the appropriate callback method on the listener object and passes the current (udpated) values. </para> <para>To unregister a listener, pass the listener object and set the events argument to LISTEN_NONE (0).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// listen
				/// </java-name>
				[Dot42.DexImport("listen", "(Landroid/telephony/PhoneStateListener;I)V", AccessFlags = 1)]
				public virtual void Listen(global::Android.Telephony.PhoneStateListener listener, int events) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the software version number for the device, for example, the IMEI/SV for GSM phones. Return null if the software version is not available.</para> <para>Requires Permission: READ_PHONE_STATE </para>        
				/// </summary>
				/// <java-name>
				/// getDeviceSoftwareVersion
				/// </java-name>
				public virtual string DeviceSoftwareVersion
				{
						[Dot42.DexImport("getDeviceSoftwareVersion", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the unique device ID, for example, the IMEI for GSM and the MEID or ESN for CDMA phones. Return null if device ID is not available.</para> <para>Requires Permission: READ_PHONE_STATE </para>        
				/// </summary>
				/// <java-name>
				/// getDeviceId
				/// </java-name>
				public virtual string DeviceId
				{
						[Dot42.DexImport("getDeviceId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the current location of the device. </para> <para>If there is only one radio in the device and that radio has an LTE connection, this method will return null. The implementation must not to try add LTE identifiers into the existing cdma/gsm classes. </para> <para>In the future this call will be deprecated. </para> <para></para> <para>Requires Permission: ACCESS_COARSE_LOCATION or ACCESS_FINE_LOCATION. </para>        
				/// </summary>
				/// <returns>
				///  <para>Current location of the device or null if not available.</para>
				/// </returns>
				/// <java-name>
				/// getCellLocation
				/// </java-name>
				public virtual global::Android.Telephony.CellLocation CellLocation
				{
						[Dot42.DexImport("getCellLocation", "()Landroid/telephony/CellLocation;", AccessFlags = 1)]
						get{ return default(global::Android.Telephony.CellLocation); }
				}

				/// <summary>
				///  <para>Returns the neighboring cell information of the device. The getAllCellInfo is preferred and use this only if getAllCellInfo return nulls or an empty list. </para> <para>In the future this call will be deprecated. </para> <para></para> <para>Requires Permission: (} </para>        
				/// </summary>
				/// <returns>
				///  <para>List of NeighboringCellInfo or null if info unavailable.</para>
				/// </returns>
				/// <java-name>
				/// getNeighboringCellInfo
				/// </java-name>
				public virtual global::Java.Util.IList<global::Android.Telephony.NeighboringCellInfo> NeighboringCellInfo
				{
						[Dot42.DexImport("getNeighboringCellInfo", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/telephony/NeighboringCellInfo;>;")]
						get{ return default(global::Java.Util.IList<global::Android.Telephony.NeighboringCellInfo>); }
				}

				/// <summary>
				///  <para>Returns a constant indicating the device phone type. This indicates the type of radio used to transmit voice calls.</para> <para> <para>PHONE_TYPE_NONE </para> <para>PHONE_TYPE_GSM </para> <para>PHONE_TYPE_CDMA </para> <para>PHONE_TYPE_SIP </para></para>        
				/// </summary>
				/// <java-name>
				/// getPhoneType
				/// </java-name>
				public virtual int PhoneType
				{
						[Dot42.DexImport("getPhoneType", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the alphabetic name of current registered operator. </para> <para>Availability: Only when user is registered to a network. Result may be unreliable on CDMA networks (use getPhoneType() to determine if on a CDMA network). </para>        
				/// </summary>
				/// <java-name>
				/// getNetworkOperatorName
				/// </java-name>
				public virtual string NetworkOperatorName
				{
						[Dot42.DexImport("getNetworkOperatorName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the numeric name (MCC+MNC) of current registered operator. </para> <para>Availability: Only when user is registered to a network. Result may be unreliable on CDMA networks (use getPhoneType() to determine if on a CDMA network). </para>        
				/// </summary>
				/// <java-name>
				/// getNetworkOperator
				/// </java-name>
				public virtual string NetworkOperator
				{
						[Dot42.DexImport("getNetworkOperator", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns true if the device is considered roaming on the current network, for GSM purposes. </para> <para>Availability: Only when user registered to a network. </para>        
				/// </summary>
				/// <java-name>
				/// isNetworkRoaming
				/// </java-name>
				public virtual bool IsNetworkRoaming
				{
						[Dot42.DexImport("isNetworkRoaming", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the ISO country code equivalent of the current registered operator's MCC (Mobile Country Code). </para> <para>Availability: Only when user is registered to a network. Result may be unreliable on CDMA networks (use getPhoneType() to determine if on a CDMA network). </para>        
				/// </summary>
				/// <java-name>
				/// getNetworkCountryIso
				/// </java-name>
				public virtual string NetworkCountryIso
				{
						[Dot42.DexImport("getNetworkCountryIso", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the NETWORK_TYPE_xxxx for current data connection. </para>
				/// </returns>
				/// <java-name>
				/// getNetworkType
				/// </java-name>
				public virtual int NetworkType
				{
						[Dot42.DexImport("getNetworkType", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if a ICC card is present </para>
				/// </returns>
				/// <java-name>
				/// hasIccCard
				/// </java-name>
				public virtual bool HasIccCard
				{
						[Dot42.DexImport("hasIccCard", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns a constant indicating the state of the device SIM card.</para> <para> <para>SIM_STATE_UNKNOWN </para> <para>SIM_STATE_ABSENT </para> <para>SIM_STATE_PIN_REQUIRED </para> <para>SIM_STATE_PUK_REQUIRED </para> <para>SIM_STATE_NETWORK_LOCKED </para> <para>SIM_STATE_READY </para></para>        
				/// </summary>
				/// <java-name>
				/// getSimState
				/// </java-name>
				public virtual int SimState
				{
						[Dot42.DexImport("getSimState", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the MCC+MNC (mobile country code + mobile network code) of the provider of the SIM. 5 or 6 decimal digits. </para> <para>Availability: SIM state must be SIM_STATE_READY</para> <para> <para>getSimState </para></para>        
				/// </summary>
				/// <java-name>
				/// getSimOperator
				/// </java-name>
				public virtual string SimOperator
				{
						[Dot42.DexImport("getSimOperator", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the Service Provider Name (SPN). </para> <para>Availability: SIM state must be SIM_STATE_READY</para> <para> <para>getSimState </para></para>        
				/// </summary>
				/// <java-name>
				/// getSimOperatorName
				/// </java-name>
				public virtual string SimOperatorName
				{
						[Dot42.DexImport("getSimOperatorName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the ISO country code equivalent for the SIM provider's country code. </para>        
				/// </summary>
				/// <java-name>
				/// getSimCountryIso
				/// </java-name>
				public virtual string SimCountryIso
				{
						[Dot42.DexImport("getSimCountryIso", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the serial number of the SIM, if applicable. Return null if it is unavailable. </para> <para>Requires Permission: READ_PHONE_STATE </para>        
				/// </summary>
				/// <java-name>
				/// getSimSerialNumber
				/// </java-name>
				public virtual string SimSerialNumber
				{
						[Dot42.DexImport("getSimSerialNumber", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the unique subscriber ID, for example, the IMSI for a GSM phone. Return null if it is unavailable. </para> <para>Requires Permission: READ_PHONE_STATE </para>        
				/// </summary>
				/// <java-name>
				/// getSubscriberId
				/// </java-name>
				public virtual string SubscriberId
				{
						[Dot42.DexImport("getSubscriberId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the phone number string for line 1, for example, the MSISDN for a GSM phone. Return null if it is unavailable. </para> <para>Requires Permission: READ_PHONE_STATE </para>        
				/// </summary>
				/// <java-name>
				/// getLine1Number
				/// </java-name>
				public virtual string Line1Number
				{
						[Dot42.DexImport("getLine1Number", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the voice mail number. Return null if it is unavailable. </para> <para>Requires Permission: READ_PHONE_STATE </para>        
				/// </summary>
				/// <java-name>
				/// getVoiceMailNumber
				/// </java-name>
				public virtual string VoiceMailNumber
				{
						[Dot42.DexImport("getVoiceMailNumber", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Retrieves the alphabetic identifier associated with the voice mail number. </para> <para>Requires Permission: READ_PHONE_STATE </para>        
				/// </summary>
				/// <java-name>
				/// getVoiceMailAlphaTag
				/// </java-name>
				public virtual string VoiceMailAlphaTag
				{
						[Dot42.DexImport("getVoiceMailAlphaTag", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns a constant indicating the call state (cellular) on the device. </para>        
				/// </summary>
				/// <java-name>
				/// getCallState
				/// </java-name>
				public virtual int CallState
				{
						[Dot42.DexImport("getCallState", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns a constant indicating the type of activity on a data connection (cellular).</para> <para> <para>DATA_ACTIVITY_NONE </para> <para>DATA_ACTIVITY_IN </para> <para>DATA_ACTIVITY_OUT </para> <para>DATA_ACTIVITY_INOUT </para> <para>DATA_ACTIVITY_DORMANT </para></para>        
				/// </summary>
				/// <java-name>
				/// getDataActivity
				/// </java-name>
				public virtual int DataActivity
				{
						[Dot42.DexImport("getDataActivity", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns a constant indicating the current data connection state (cellular).</para> <para> <para>DATA_DISCONNECTED </para> <para>DATA_CONNECTING </para> <para>DATA_CONNECTED </para> <para>DATA_SUSPENDED </para></para>        
				/// </summary>
				/// <java-name>
				/// getDataState
				/// </java-name>
				public virtual int DataState
				{
						[Dot42.DexImport("getDataState", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns all observed cell information from all radios on the device including the primary and neighboring cells. This does not cause or change the rate of PhoneStateListner::onCellInfoChanged. </para> <para>The list can include one or more of CellInfoGsm, CellInfoCdma, CellInfoLte and CellInfoCdma in any combination. Specifically on devices with multiple radios it is typical to see instances of one or more of any these in the list. In addition 0, 1 or more CellInfo objects may return isRegistered() true. </para> <para>This is preferred over using getCellLocation although for older devices this may return null in which case getCellLocation should be called. </para> <para></para> <para>Requires Permission: android.Manifest.permission#ACCESS_COARSE_LOCATION </para>        
				/// </summary>
				/// <returns>
				///  <para>List of CellInfo or null if info unavailable.</para>
				/// </returns>
				/// <java-name>
				/// getAllCellInfo
				/// </java-name>
				public virtual global::Java.Util.IList<global::Android.Telephony.CellInfo> AllCellInfo
				{
						[Dot42.DexImport("getAllCellInfo", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/telephony/CellInfo;>;")]
						get{ return default(global::Java.Util.IList<global::Android.Telephony.CellInfo>); }
				}

		}

}

