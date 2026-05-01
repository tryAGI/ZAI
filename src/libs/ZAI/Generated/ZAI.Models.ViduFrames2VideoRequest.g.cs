#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ViduFrames2VideoRequest : global::System.IEquatable<ViduFrames2VideoRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ZAI.ViduFrames2VideoRequestVariant1? ViduFrames2VideoRequestVariant1 { get; init; }
#else
        public global::ZAI.ViduFrames2VideoRequestVariant1? ViduFrames2VideoRequestVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ViduFrames2VideoRequestVariant1))]
#endif
        public bool IsViduFrames2VideoRequestVariant1 => ViduFrames2VideoRequestVariant1 != null;

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
        public static implicit operator ViduFrames2VideoRequest(global::ZAI.ViduFrames2VideoRequestVariant1 value) => new ViduFrames2VideoRequest((global::ZAI.ViduFrames2VideoRequestVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ZAI.ViduFrames2VideoRequestVariant1?(ViduFrames2VideoRequest @this) => @this.ViduFrames2VideoRequestVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ViduFrames2VideoRequest(global::ZAI.ViduFrames2VideoRequestVariant1? value)
        {
            ViduFrames2VideoRequestVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ViduFrames2VideoRequest(global::ZAI.VideoCommonRequest value) => new ViduFrames2VideoRequest((global::ZAI.VideoCommonRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ZAI.VideoCommonRequest?(ViduFrames2VideoRequest @this) => @this.Common;

        /// <summary>
        /// 
        /// </summary>
        public ViduFrames2VideoRequest(global::ZAI.VideoCommonRequest? value)
        {
            Common = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ViduFrames2VideoRequest(
            global::ZAI.ViduFrames2VideoRequestVariant1? viduFrames2VideoRequestVariant1,
            global::ZAI.VideoCommonRequest? common
            )
        {
            ViduFrames2VideoRequestVariant1 = viduFrames2VideoRequestVariant1;
            Common = common;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Common as object ??
            ViduFrames2VideoRequestVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ViduFrames2VideoRequestVariant1?.ToString() ??
            Common?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsViduFrames2VideoRequestVariant1 && IsCommon;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ZAI.ViduFrames2VideoRequestVariant1?, TResult>? viduFrames2VideoRequestVariant1 = null,
            global::System.Func<global::ZAI.VideoCommonRequest?, TResult>? common = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsViduFrames2VideoRequestVariant1 && viduFrames2VideoRequestVariant1 != null)
            {
                return viduFrames2VideoRequestVariant1(ViduFrames2VideoRequestVariant1!);
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
            global::System.Action<global::ZAI.ViduFrames2VideoRequestVariant1?>? viduFrames2VideoRequestVariant1 = null,
            global::System.Action<global::ZAI.VideoCommonRequest?>? common = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsViduFrames2VideoRequestVariant1)
            {
                viduFrames2VideoRequestVariant1?.Invoke(ViduFrames2VideoRequestVariant1!);
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
                ViduFrames2VideoRequestVariant1,
                typeof(global::ZAI.ViduFrames2VideoRequestVariant1),
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
        public bool Equals(ViduFrames2VideoRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ZAI.ViduFrames2VideoRequestVariant1?>.Default.Equals(ViduFrames2VideoRequestVariant1, other.ViduFrames2VideoRequestVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::ZAI.VideoCommonRequest?>.Default.Equals(Common, other.Common) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ViduFrames2VideoRequest obj1, ViduFrames2VideoRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ViduFrames2VideoRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ViduFrames2VideoRequest obj1, ViduFrames2VideoRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ViduFrames2VideoRequest o && Equals(o);
        }
    }
}
