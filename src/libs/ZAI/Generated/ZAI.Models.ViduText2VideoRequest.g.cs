#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ViduText2VideoRequest : global::System.IEquatable<ViduText2VideoRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ZAI.ViduText2VideoRequestVariant1? ViduText2VideoRequestVariant1 { get; init; }
#else
        public global::ZAI.ViduText2VideoRequestVariant1? ViduText2VideoRequestVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ViduText2VideoRequestVariant1))]
#endif
        public bool IsViduText2VideoRequestVariant1 => ViduText2VideoRequestVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickViduText2VideoRequestVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ZAI.ViduText2VideoRequestVariant1? value)
        {
            value = ViduText2VideoRequestVariant1;
            return IsViduText2VideoRequestVariant1;
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
        public static implicit operator ViduText2VideoRequest(global::ZAI.ViduText2VideoRequestVariant1 value) => new ViduText2VideoRequest((global::ZAI.ViduText2VideoRequestVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ZAI.ViduText2VideoRequestVariant1?(ViduText2VideoRequest @this) => @this.ViduText2VideoRequestVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ViduText2VideoRequest(global::ZAI.ViduText2VideoRequestVariant1? value)
        {
            ViduText2VideoRequestVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ViduText2VideoRequest(global::ZAI.VideoCommonRequest value) => new ViduText2VideoRequest((global::ZAI.VideoCommonRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ZAI.VideoCommonRequest?(ViduText2VideoRequest @this) => @this.Common;

        /// <summary>
        /// 
        /// </summary>
        public ViduText2VideoRequest(global::ZAI.VideoCommonRequest? value)
        {
            Common = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ViduText2VideoRequest(
            global::ZAI.ViduText2VideoRequestVariant1? viduText2VideoRequestVariant1,
            global::ZAI.VideoCommonRequest? common
            )
        {
            ViduText2VideoRequestVariant1 = viduText2VideoRequestVariant1;
            Common = common;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Common as object ??
            ViduText2VideoRequestVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ViduText2VideoRequestVariant1?.ToString() ??
            Common?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsViduText2VideoRequestVariant1 && IsCommon;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ZAI.ViduText2VideoRequestVariant1, TResult>? viduText2VideoRequestVariant1 = null,
            global::System.Func<global::ZAI.VideoCommonRequest, TResult>? common = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsViduText2VideoRequestVariant1 && viduText2VideoRequestVariant1 != null)
            {
                return viduText2VideoRequestVariant1(ViduText2VideoRequestVariant1!);
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
            global::System.Action<global::ZAI.ViduText2VideoRequestVariant1>? viduText2VideoRequestVariant1 = null,

            global::System.Action<global::ZAI.VideoCommonRequest>? common = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsViduText2VideoRequestVariant1)
            {
                viduText2VideoRequestVariant1?.Invoke(ViduText2VideoRequestVariant1!);
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
            global::System.Action<global::ZAI.ViduText2VideoRequestVariant1>? viduText2VideoRequestVariant1 = null,
            global::System.Action<global::ZAI.VideoCommonRequest>? common = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsViduText2VideoRequestVariant1)
            {
                viduText2VideoRequestVariant1?.Invoke(ViduText2VideoRequestVariant1!);
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
                ViduText2VideoRequestVariant1,
                typeof(global::ZAI.ViduText2VideoRequestVariant1),
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
        public bool Equals(ViduText2VideoRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ZAI.ViduText2VideoRequestVariant1?>.Default.Equals(ViduText2VideoRequestVariant1, other.ViduText2VideoRequestVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::ZAI.VideoCommonRequest?>.Default.Equals(Common, other.Common) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ViduText2VideoRequest obj1, ViduText2VideoRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ViduText2VideoRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ViduText2VideoRequest obj1, ViduText2VideoRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ViduText2VideoRequest o && Equals(o);
        }
    }
}
