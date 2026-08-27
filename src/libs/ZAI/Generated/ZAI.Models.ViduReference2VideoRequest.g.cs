#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ZAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ViduReference2VideoRequest : global::System.IEquatable<ViduReference2VideoRequest>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ZAI.ViduReference2VideoRequestVariant1? ViduReference2VideoRequestVariant1 { get; init; }
#else
        public global::ZAI.ViduReference2VideoRequestVariant1? ViduReference2VideoRequestVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ViduReference2VideoRequestVariant1))]
#endif
        public bool IsViduReference2VideoRequestVariant1 => ViduReference2VideoRequestVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickViduReference2VideoRequestVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ZAI.ViduReference2VideoRequestVariant1? value)
        {
            value = ViduReference2VideoRequestVariant1;
            return IsViduReference2VideoRequestVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ViduReference2VideoRequestVariant1 PickViduReference2VideoRequestVariant1() => IsViduReference2VideoRequestVariant1
            ? ViduReference2VideoRequestVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ViduReference2VideoRequestVariant1' but the value was {ToString()}.");

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
        public static implicit operator ViduReference2VideoRequest(global::ZAI.ViduReference2VideoRequestVariant1 value) => new ViduReference2VideoRequest((global::ZAI.ViduReference2VideoRequestVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ZAI.ViduReference2VideoRequestVariant1?(ViduReference2VideoRequest @this) => @this.ViduReference2VideoRequestVariant1;

        /// <summary>
        ///
        /// </summary>
        public ViduReference2VideoRequest(global::ZAI.ViduReference2VideoRequestVariant1? value)
        {
            ViduReference2VideoRequestVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ViduReference2VideoRequest FromViduReference2VideoRequestVariant1(global::ZAI.ViduReference2VideoRequestVariant1? value) => new ViduReference2VideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ViduReference2VideoRequest(global::ZAI.VideoCommonRequest value) => new ViduReference2VideoRequest((global::ZAI.VideoCommonRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ZAI.VideoCommonRequest?(ViduReference2VideoRequest @this) => @this.Common;

        /// <summary>
        ///
        /// </summary>
        public ViduReference2VideoRequest(global::ZAI.VideoCommonRequest? value)
        {
            Common = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ViduReference2VideoRequest FromCommon(global::ZAI.VideoCommonRequest? value) => new ViduReference2VideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public ViduReference2VideoRequest(
            global::ZAI.ViduReference2VideoRequestVariant1? viduReference2VideoRequestVariant1,
            global::ZAI.VideoCommonRequest? common
            )
        {
            ViduReference2VideoRequestVariant1 = viduReference2VideoRequestVariant1;
            Common = common;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Common as object ??
            ViduReference2VideoRequestVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ViduReference2VideoRequestVariant1?.ToString() ??
            Common?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsViduReference2VideoRequestVariant1 && IsCommon;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ZAI.ViduReference2VideoRequestVariant1, TResult>? viduReference2VideoRequestVariant1 = null,
            global::System.Func<global::ZAI.VideoCommonRequest, TResult>? common = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsViduReference2VideoRequestVariant1 && viduReference2VideoRequestVariant1 != null)
            {
                return viduReference2VideoRequestVariant1(ViduReference2VideoRequestVariant1!);
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
            global::System.Action<global::ZAI.ViduReference2VideoRequestVariant1>? viduReference2VideoRequestVariant1 = null,

            global::System.Action<global::ZAI.VideoCommonRequest>? common = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsViduReference2VideoRequestVariant1)
            {
                viduReference2VideoRequestVariant1?.Invoke(ViduReference2VideoRequestVariant1!);
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
            global::System.Action<global::ZAI.ViduReference2VideoRequestVariant1>? viduReference2VideoRequestVariant1 = null,
            global::System.Action<global::ZAI.VideoCommonRequest>? common = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsViduReference2VideoRequestVariant1)
            {
                viduReference2VideoRequestVariant1?.Invoke(ViduReference2VideoRequestVariant1!);
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
                ViduReference2VideoRequestVariant1,
                typeof(global::ZAI.ViduReference2VideoRequestVariant1),
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
        public bool Equals(ViduReference2VideoRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ZAI.ViduReference2VideoRequestVariant1?>.Default.Equals(ViduReference2VideoRequestVariant1, other.ViduReference2VideoRequestVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::ZAI.VideoCommonRequest?>.Default.Equals(Common, other.Common)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ViduReference2VideoRequest obj1, ViduReference2VideoRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ViduReference2VideoRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ViduReference2VideoRequest obj1, ViduReference2VideoRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ViduReference2VideoRequest o && Equals(o);
        }
    }
}
