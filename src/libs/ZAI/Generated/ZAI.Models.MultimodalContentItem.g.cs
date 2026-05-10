#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MultimodalContentItem : global::System.IEquatable<MultimodalContentItem>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ZAI.MultimodalContentItemText? Text { get; init; }
#else
        public global::ZAI.MultimodalContentItemText? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ZAI.MultimodalContentItemText? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ZAI.MultimodalContentItemImage? Image { get; init; }
#else
        public global::ZAI.MultimodalContentItemImage? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ZAI.MultimodalContentItemImage? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ZAI.MultimodalContentItemAudio? Audio { get; init; }
#else
        public global::ZAI.MultimodalContentItemAudio? Audio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Audio))]
#endif
        public bool IsAudio => Audio != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAudio(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ZAI.MultimodalContentItemAudio? value)
        {
            value = Audio;
            return IsAudio;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ZAI.MultimodalContentItemVideo? Video { get; init; }
#else
        public global::ZAI.MultimodalContentItemVideo? Video { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Video))]
#endif
        public bool IsVideo => Video != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVideo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ZAI.MultimodalContentItemVideo? value)
        {
            value = Video;
            return IsVideo;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ZAI.MultimodalContentItemFile? File { get; init; }
#else
        public global::ZAI.MultimodalContentItemFile? File { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(File))]
#endif
        public bool IsFile => File != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFile(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ZAI.MultimodalContentItemFile? value)
        {
            value = File;
            return IsFile;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MultimodalContentItem(global::ZAI.MultimodalContentItemText value) => new MultimodalContentItem((global::ZAI.MultimodalContentItemText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ZAI.MultimodalContentItemText?(MultimodalContentItem @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public MultimodalContentItem(global::ZAI.MultimodalContentItemText? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MultimodalContentItem FromText(global::ZAI.MultimodalContentItemText? value) => new MultimodalContentItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MultimodalContentItem(global::ZAI.MultimodalContentItemImage value) => new MultimodalContentItem((global::ZAI.MultimodalContentItemImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ZAI.MultimodalContentItemImage?(MultimodalContentItem @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public MultimodalContentItem(global::ZAI.MultimodalContentItemImage? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MultimodalContentItem FromImage(global::ZAI.MultimodalContentItemImage? value) => new MultimodalContentItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MultimodalContentItem(global::ZAI.MultimodalContentItemAudio value) => new MultimodalContentItem((global::ZAI.MultimodalContentItemAudio?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ZAI.MultimodalContentItemAudio?(MultimodalContentItem @this) => @this.Audio;

        /// <summary>
        /// 
        /// </summary>
        public MultimodalContentItem(global::ZAI.MultimodalContentItemAudio? value)
        {
            Audio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MultimodalContentItem FromAudio(global::ZAI.MultimodalContentItemAudio? value) => new MultimodalContentItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MultimodalContentItem(global::ZAI.MultimodalContentItemVideo value) => new MultimodalContentItem((global::ZAI.MultimodalContentItemVideo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ZAI.MultimodalContentItemVideo?(MultimodalContentItem @this) => @this.Video;

        /// <summary>
        /// 
        /// </summary>
        public MultimodalContentItem(global::ZAI.MultimodalContentItemVideo? value)
        {
            Video = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MultimodalContentItem FromVideo(global::ZAI.MultimodalContentItemVideo? value) => new MultimodalContentItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MultimodalContentItem(global::ZAI.MultimodalContentItemFile value) => new MultimodalContentItem((global::ZAI.MultimodalContentItemFile?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ZAI.MultimodalContentItemFile?(MultimodalContentItem @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public MultimodalContentItem(global::ZAI.MultimodalContentItemFile? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MultimodalContentItem FromFile(global::ZAI.MultimodalContentItemFile? value) => new MultimodalContentItem(value);

        /// <summary>
        /// 
        /// </summary>
        public MultimodalContentItem(
            global::ZAI.MultimodalContentItemText? text,
            global::ZAI.MultimodalContentItemImage? image,
            global::ZAI.MultimodalContentItemAudio? audio,
            global::ZAI.MultimodalContentItemVideo? video,
            global::ZAI.MultimodalContentItemFile? file
            )
        {
            Text = text;
            Image = image;
            Audio = audio;
            Video = video;
            File = file;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            File as object ??
            Video as object ??
            Audio as object ??
            Image as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Image?.ToString() ??
            Audio?.ToString() ??
            Video?.ToString() ??
            File?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage && !IsAudio && !IsVideo && !IsFile || !IsText && IsImage && !IsAudio && !IsVideo && !IsFile || !IsText && !IsImage && IsAudio && !IsVideo && !IsFile || !IsText && !IsImage && !IsAudio && IsVideo && !IsFile || !IsText && !IsImage && !IsAudio && !IsVideo && IsFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ZAI.MultimodalContentItemText, TResult>? text = null,
            global::System.Func<global::ZAI.MultimodalContentItemImage, TResult>? image = null,
            global::System.Func<global::ZAI.MultimodalContentItemAudio, TResult>? audio = null,
            global::System.Func<global::ZAI.MultimodalContentItemVideo, TResult>? video = null,
            global::System.Func<global::ZAI.MultimodalContentItemFile, TResult>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsImage && image != null)
            {
                return image(Image!);
            }
            else if (IsAudio && audio != null)
            {
                return audio(Audio!);
            }
            else if (IsVideo && video != null)
            {
                return video(Video!);
            }
            else if (IsFile && file != null)
            {
                return file(File!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ZAI.MultimodalContentItemText>? text = null,

            global::System.Action<global::ZAI.MultimodalContentItemImage>? image = null,

            global::System.Action<global::ZAI.MultimodalContentItemAudio>? audio = null,

            global::System.Action<global::ZAI.MultimodalContentItemVideo>? video = null,

            global::System.Action<global::ZAI.MultimodalContentItemFile>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsAudio)
            {
                audio?.Invoke(Audio!);
            }
            else if (IsVideo)
            {
                video?.Invoke(Video!);
            }
            else if (IsFile)
            {
                file?.Invoke(File!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ZAI.MultimodalContentItemText>? text = null,
            global::System.Action<global::ZAI.MultimodalContentItemImage>? image = null,
            global::System.Action<global::ZAI.MultimodalContentItemAudio>? audio = null,
            global::System.Action<global::ZAI.MultimodalContentItemVideo>? video = null,
            global::System.Action<global::ZAI.MultimodalContentItemFile>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsAudio)
            {
                audio?.Invoke(Audio!);
            }
            else if (IsVideo)
            {
                video?.Invoke(Video!);
            }
            else if (IsFile)
            {
                file?.Invoke(File!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::ZAI.MultimodalContentItemText),
                Image,
                typeof(global::ZAI.MultimodalContentItemImage),
                Audio,
                typeof(global::ZAI.MultimodalContentItemAudio),
                Video,
                typeof(global::ZAI.MultimodalContentItemVideo),
                File,
                typeof(global::ZAI.MultimodalContentItemFile),
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
        public bool Equals(MultimodalContentItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ZAI.MultimodalContentItemText?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::ZAI.MultimodalContentItemImage?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::ZAI.MultimodalContentItemAudio?>.Default.Equals(Audio, other.Audio) &&
                global::System.Collections.Generic.EqualityComparer<global::ZAI.MultimodalContentItemVideo?>.Default.Equals(Video, other.Video) &&
                global::System.Collections.Generic.EqualityComparer<global::ZAI.MultimodalContentItemFile?>.Default.Equals(File, other.File) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MultimodalContentItem obj1, MultimodalContentItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MultimodalContentItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MultimodalContentItem obj1, MultimodalContentItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MultimodalContentItem o && Equals(o);
        }
    }
}
