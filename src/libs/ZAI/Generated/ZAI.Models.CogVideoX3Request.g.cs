#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CogVideoX3Request : global::System.IEquatable<CogVideoX3Request>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ZAI.CogVideoX3RequestVariant1? CogVideoX3RequestVariant1 { get; init; }
#else
        public global::ZAI.CogVideoX3RequestVariant1? CogVideoX3RequestVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CogVideoX3RequestVariant1))]
#endif
        public bool IsCogVideoX3RequestVariant1 => CogVideoX3RequestVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCogVideoX3RequestVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ZAI.CogVideoX3RequestVariant1? value)
        {
            value = CogVideoX3RequestVariant1;
            return IsCogVideoX3RequestVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ZAI.VideoCommonRequest? Common { get; init; }
#else
        public global::ZAI.VideoCommonRequest? Common { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Common))]
#endif
        public bool IsCommon => Common != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCommon(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ZAI.VideoCommonRequest? value)
        {
            value = Common;
            return IsCommon;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CogVideoX3Request(global::ZAI.CogVideoX3RequestVariant1 value) => new CogVideoX3Request((global::ZAI.CogVideoX3RequestVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ZAI.CogVideoX3RequestVariant1?(CogVideoX3Request @this) => @this.CogVideoX3RequestVariant1;

        /// <summary>
        /// 
        /// </summary>
        public CogVideoX3Request(global::ZAI.CogVideoX3RequestVariant1? value)
        {
            CogVideoX3RequestVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CogVideoX3Request FromCogVideoX3RequestVariant1(global::ZAI.CogVideoX3RequestVariant1? value) => new CogVideoX3Request(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CogVideoX3Request(global::ZAI.VideoCommonRequest value) => new CogVideoX3Request((global::ZAI.VideoCommonRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ZAI.VideoCommonRequest?(CogVideoX3Request @this) => @this.Common;

        /// <summary>
        /// 
        /// </summary>
        public CogVideoX3Request(global::ZAI.VideoCommonRequest? value)
        {
            Common = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CogVideoX3Request FromCommon(global::ZAI.VideoCommonRequest? value) => new CogVideoX3Request(value);

        /// <summary>
        /// 
        /// </summary>
        public CogVideoX3Request(
            global::ZAI.CogVideoX3RequestVariant1? cogVideoX3RequestVariant1,
            global::ZAI.VideoCommonRequest? common
            )
        {
            CogVideoX3RequestVariant1 = cogVideoX3RequestVariant1;
            Common = common;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Common as object ??
            CogVideoX3RequestVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CogVideoX3RequestVariant1?.ToString() ??
            Common?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCogVideoX3RequestVariant1 && IsCommon;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ZAI.CogVideoX3RequestVariant1, TResult>? cogVideoX3RequestVariant1 = null,
            global::System.Func<global::ZAI.VideoCommonRequest, TResult>? common = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCogVideoX3RequestVariant1 && cogVideoX3RequestVariant1 != null)
            {
                return cogVideoX3RequestVariant1(CogVideoX3RequestVariant1!);
            }
            else if (IsCommon && common != null)
            {
                return common(Common!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ZAI.CogVideoX3RequestVariant1>? cogVideoX3RequestVariant1 = null,

            global::System.Action<global::ZAI.VideoCommonRequest>? common = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCogVideoX3RequestVariant1)
            {
                cogVideoX3RequestVariant1?.Invoke(CogVideoX3RequestVariant1!);
            }
            else if (IsCommon)
            {
                common?.Invoke(Common!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ZAI.CogVideoX3RequestVariant1>? cogVideoX3RequestVariant1 = null,
            global::System.Action<global::ZAI.VideoCommonRequest>? common = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCogVideoX3RequestVariant1)
            {
                cogVideoX3RequestVariant1?.Invoke(CogVideoX3RequestVariant1!);
            }
            else if (IsCommon)
            {
                common?.Invoke(Common!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CogVideoX3RequestVariant1,
                typeof(global::ZAI.CogVideoX3RequestVariant1),
                Common,
                typeof(global::ZAI.VideoCommonRequest),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(CogVideoX3Request other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ZAI.CogVideoX3RequestVariant1?>.Default.Equals(CogVideoX3RequestVariant1, other.CogVideoX3RequestVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::ZAI.VideoCommonRequest?>.Default.Equals(Common, other.Common) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CogVideoX3Request obj1, CogVideoX3Request obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CogVideoX3Request>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CogVideoX3Request obj1, CogVideoX3Request obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CogVideoX3Request o && Equals(o);
        }
    }
}
