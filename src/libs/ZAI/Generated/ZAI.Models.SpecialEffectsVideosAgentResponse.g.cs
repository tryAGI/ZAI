#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ZAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct SpecialEffectsVideosAgentResponse : global::System.IEquatable<SpecialEffectsVideosAgentResponse>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ZAI.SpecialEffectsVideosAgentResponseVariant1? SpecialEffectsVideosAgentResponseVariant1 { get; init; }
#else
        public global::ZAI.SpecialEffectsVideosAgentResponseVariant1? SpecialEffectsVideosAgentResponseVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpecialEffectsVideosAgentResponseVariant1))]
#endif
        public bool IsSpecialEffectsVideosAgentResponseVariant1 => SpecialEffectsVideosAgentResponseVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSpecialEffectsVideosAgentResponseVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ZAI.SpecialEffectsVideosAgentResponseVariant1? value)
        {
            value = SpecialEffectsVideosAgentResponseVariant1;
            return IsSpecialEffectsVideosAgentResponseVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentResponseVariant1 PickSpecialEffectsVideosAgentResponseVariant1() => IsSpecialEffectsVideosAgentResponseVariant1
            ? SpecialEffectsVideosAgentResponseVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpecialEffectsVideosAgentResponseVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ZAI.SpecialEffectsVideosAgentError? Error { get; init; }
#else
        public global::ZAI.SpecialEffectsVideosAgentError? Error { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ZAI.SpecialEffectsVideosAgentError? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentError PickError() => IsError
            ? Error!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SpecialEffectsVideosAgentResponse(global::ZAI.SpecialEffectsVideosAgentResponseVariant1 value) => new SpecialEffectsVideosAgentResponse((global::ZAI.SpecialEffectsVideosAgentResponseVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ZAI.SpecialEffectsVideosAgentResponseVariant1?(SpecialEffectsVideosAgentResponse @this) => @this.SpecialEffectsVideosAgentResponseVariant1;

        /// <summary>
        ///
        /// </summary>
        public SpecialEffectsVideosAgentResponse(global::ZAI.SpecialEffectsVideosAgentResponseVariant1? value)
        {
            SpecialEffectsVideosAgentResponseVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SpecialEffectsVideosAgentResponse FromSpecialEffectsVideosAgentResponseVariant1(global::ZAI.SpecialEffectsVideosAgentResponseVariant1? value) => new SpecialEffectsVideosAgentResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SpecialEffectsVideosAgentResponse(global::ZAI.SpecialEffectsVideosAgentError value) => new SpecialEffectsVideosAgentResponse((global::ZAI.SpecialEffectsVideosAgentError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ZAI.SpecialEffectsVideosAgentError?(SpecialEffectsVideosAgentResponse @this) => @this.Error;

        /// <summary>
        ///
        /// </summary>
        public SpecialEffectsVideosAgentResponse(global::ZAI.SpecialEffectsVideosAgentError? value)
        {
            Error = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SpecialEffectsVideosAgentResponse FromError(global::ZAI.SpecialEffectsVideosAgentError? value) => new SpecialEffectsVideosAgentResponse(value);

        /// <summary>
        ///
        /// </summary>
        public SpecialEffectsVideosAgentResponse(
            global::ZAI.SpecialEffectsVideosAgentResponseVariant1? specialEffectsVideosAgentResponseVariant1,
            global::ZAI.SpecialEffectsVideosAgentError? error
            )
        {
            SpecialEffectsVideosAgentResponseVariant1 = specialEffectsVideosAgentResponseVariant1;
            Error = error;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Error as object ??
            SpecialEffectsVideosAgentResponseVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SpecialEffectsVideosAgentResponseVariant1?.ToString() ??
            Error?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSpecialEffectsVideosAgentResponseVariant1 && IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ZAI.SpecialEffectsVideosAgentResponseVariant1, TResult>? specialEffectsVideosAgentResponseVariant1 = null,
            global::System.Func<global::ZAI.SpecialEffectsVideosAgentError, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpecialEffectsVideosAgentResponseVariant1 && specialEffectsVideosAgentResponseVariant1 != null)
            {
                return specialEffectsVideosAgentResponseVariant1(SpecialEffectsVideosAgentResponseVariant1!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ZAI.SpecialEffectsVideosAgentResponseVariant1>? specialEffectsVideosAgentResponseVariant1 = null,

            global::System.Action<global::ZAI.SpecialEffectsVideosAgentError>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpecialEffectsVideosAgentResponseVariant1)
            {
                specialEffectsVideosAgentResponseVariant1?.Invoke(SpecialEffectsVideosAgentResponseVariant1!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ZAI.SpecialEffectsVideosAgentResponseVariant1>? specialEffectsVideosAgentResponseVariant1 = null,
            global::System.Action<global::ZAI.SpecialEffectsVideosAgentError>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpecialEffectsVideosAgentResponseVariant1)
            {
                specialEffectsVideosAgentResponseVariant1?.Invoke(SpecialEffectsVideosAgentResponseVariant1!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SpecialEffectsVideosAgentResponseVariant1,
                typeof(global::ZAI.SpecialEffectsVideosAgentResponseVariant1),
                Error,
                typeof(global::ZAI.SpecialEffectsVideosAgentError),
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
        public bool Equals(SpecialEffectsVideosAgentResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ZAI.SpecialEffectsVideosAgentResponseVariant1?>.Default.Equals(SpecialEffectsVideosAgentResponseVariant1, other.SpecialEffectsVideosAgentResponseVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::ZAI.SpecialEffectsVideosAgentError?>.Default.Equals(Error, other.Error)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SpecialEffectsVideosAgentResponse obj1, SpecialEffectsVideosAgentResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SpecialEffectsVideosAgentResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SpecialEffectsVideosAgentResponse obj1, SpecialEffectsVideosAgentResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SpecialEffectsVideosAgentResponse o && Equals(o);
        }
    }
}
