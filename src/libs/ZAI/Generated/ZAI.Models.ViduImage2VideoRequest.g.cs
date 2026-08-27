#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ZAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ViduImage2VideoRequest : global::System.IEquatable<ViduImage2VideoRequest>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ZAI.ViduImage2VideoRequestVariant1? ViduImage2VideoRequestVariant1 { get; init; }
#else
        public global::ZAI.ViduImage2VideoRequestVariant1? ViduImage2VideoRequestVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ViduImage2VideoRequestVariant1))]
#endif
        public bool IsViduImage2VideoRequestVariant1 => ViduImage2VideoRequestVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickViduImage2VideoRequestVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ZAI.ViduImage2VideoRequestVariant1? value)
        {
            value = ViduImage2VideoRequestVariant1;
            return IsViduImage2VideoRequestVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ViduImage2VideoRequestVariant1 PickViduImage2VideoRequestVariant1() => IsViduImage2VideoRequestVariant1
            ? ViduImage2VideoRequestVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ViduImage2VideoRequestVariant1' but the value was {ToString()}.");

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
        public global::ZAI.VideoCommonRequest PickCommon() => IsCommon
            ? Common!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Common' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ViduImage2VideoRequest(global::ZAI.ViduImage2VideoRequestVariant1 value) => new ViduImage2VideoRequest((global::ZAI.ViduImage2VideoRequestVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ZAI.ViduImage2VideoRequestVariant1?(ViduImage2VideoRequest @this) => @this.ViduImage2VideoRequestVariant1;

        /// <summary>
        ///
        /// </summary>
        public ViduImage2VideoRequest(global::ZAI.ViduImage2VideoRequestVariant1? value)
        {
            ViduImage2VideoRequestVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ViduImage2VideoRequest FromViduImage2VideoRequestVariant1(global::ZAI.ViduImage2VideoRequestVariant1? value) => new ViduImage2VideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ViduImage2VideoRequest(global::ZAI.VideoCommonRequest value) => new ViduImage2VideoRequest((global::ZAI.VideoCommonRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ZAI.VideoCommonRequest?(ViduImage2VideoRequest @this) => @this.Common;

        /// <summary>
        ///
        /// </summary>
        public ViduImage2VideoRequest(global::ZAI.VideoCommonRequest? value)
        {
            Common = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ViduImage2VideoRequest FromCommon(global::ZAI.VideoCommonRequest? value) => new ViduImage2VideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public ViduImage2VideoRequest(
            global::ZAI.ViduImage2VideoRequestVariant1? viduImage2VideoRequestVariant1,
            global::ZAI.VideoCommonRequest? common
            )
        {
            ViduImage2VideoRequestVariant1 = viduImage2VideoRequestVariant1;
            Common = common;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Common as object ??
            ViduImage2VideoRequestVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ViduImage2VideoRequestVariant1?.ToString() ??
            Common?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsViduImage2VideoRequestVariant1 && IsCommon;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ZAI.ViduImage2VideoRequestVariant1, TResult>? viduImage2VideoRequestVariant1 = null,
            global::System.Func<global::ZAI.VideoCommonRequest, TResult>? common = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsViduImage2VideoRequestVariant1 && viduImage2VideoRequestVariant1 != null)
            {
                return viduImage2VideoRequestVariant1(ViduImage2VideoRequestVariant1!);
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
            global::System.Action<global::ZAI.ViduImage2VideoRequestVariant1>? viduImage2VideoRequestVariant1 = null,

            global::System.Action<global::ZAI.VideoCommonRequest>? common = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsViduImage2VideoRequestVariant1)
            {
                viduImage2VideoRequestVariant1?.Invoke(ViduImage2VideoRequestVariant1!);
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
            global::System.Action<global::ZAI.ViduImage2VideoRequestVariant1>? viduImage2VideoRequestVariant1 = null,
            global::System.Action<global::ZAI.VideoCommonRequest>? common = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsViduImage2VideoRequestVariant1)
            {
                viduImage2VideoRequestVariant1?.Invoke(ViduImage2VideoRequestVariant1!);
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
                ViduImage2VideoRequestVariant1,
                typeof(global::ZAI.ViduImage2VideoRequestVariant1),
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
        public bool Equals(ViduImage2VideoRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ZAI.ViduImage2VideoRequestVariant1?>.Default.Equals(ViduImage2VideoRequestVariant1, other.ViduImage2VideoRequestVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::ZAI.VideoCommonRequest?>.Default.Equals(Common, other.Common)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ViduImage2VideoRequest obj1, ViduImage2VideoRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ViduImage2VideoRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ViduImage2VideoRequest obj1, ViduImage2VideoRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ViduImage2VideoRequest o && Equals(o);
        }
    }
}
