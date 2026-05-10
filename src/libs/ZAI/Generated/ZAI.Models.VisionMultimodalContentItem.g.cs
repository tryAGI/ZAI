#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct VisionMultimodalContentItem : global::System.IEquatable<VisionMultimodalContentItem>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ZAI.VisionMultimodalContentItemText? Text { get; init; }
#else
        public global::ZAI.VisionMultimodalContentItemText? Text { get; }
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
            out global::ZAI.VisionMultimodalContentItemText? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemText PickText() => IsText
            ? Text!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ZAI.VisionMultimodalContentItemImage? Image { get; init; }
#else
        public global::ZAI.VisionMultimodalContentItemImage? Image { get; }
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
            out global::ZAI.VisionMultimodalContentItemImage? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemImage PickImage() => IsImage
            ? Image!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ZAI.VisionMultimodalContentItemVideo? Video { get; init; }
#else
        public global::ZAI.VisionMultimodalContentItemVideo? Video { get; }
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
            out global::ZAI.VisionMultimodalContentItemVideo? value)
        {
            value = Video;
            return IsVideo;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemVideo PickVideo() => IsVideo
            ? Video!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Video' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ZAI.VisionMultimodalContentItemFile? File { get; init; }
#else
        public global::ZAI.VisionMultimodalContentItemFile? File { get; }
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
            out global::ZAI.VisionMultimodalContentItemFile? value)
        {
            value = File;
            return IsFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemFile PickFile() => IsFile
            ? File!
            : throw new global::System.InvalidOperationException($"Expected union variant 'File' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VisionMultimodalContentItem(global::ZAI.VisionMultimodalContentItemText value) => new VisionMultimodalContentItem((global::ZAI.VisionMultimodalContentItemText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ZAI.VisionMultimodalContentItemText?(VisionMultimodalContentItem @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public VisionMultimodalContentItem(global::ZAI.VisionMultimodalContentItemText? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VisionMultimodalContentItem FromText(global::ZAI.VisionMultimodalContentItemText? value) => new VisionMultimodalContentItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VisionMultimodalContentItem(global::ZAI.VisionMultimodalContentItemImage value) => new VisionMultimodalContentItem((global::ZAI.VisionMultimodalContentItemImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ZAI.VisionMultimodalContentItemImage?(VisionMultimodalContentItem @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public VisionMultimodalContentItem(global::ZAI.VisionMultimodalContentItemImage? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VisionMultimodalContentItem FromImage(global::ZAI.VisionMultimodalContentItemImage? value) => new VisionMultimodalContentItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VisionMultimodalContentItem(global::ZAI.VisionMultimodalContentItemVideo value) => new VisionMultimodalContentItem((global::ZAI.VisionMultimodalContentItemVideo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ZAI.VisionMultimodalContentItemVideo?(VisionMultimodalContentItem @this) => @this.Video;

        /// <summary>
        /// 
        /// </summary>
        public VisionMultimodalContentItem(global::ZAI.VisionMultimodalContentItemVideo? value)
        {
            Video = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VisionMultimodalContentItem FromVideo(global::ZAI.VisionMultimodalContentItemVideo? value) => new VisionMultimodalContentItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VisionMultimodalContentItem(global::ZAI.VisionMultimodalContentItemFile value) => new VisionMultimodalContentItem((global::ZAI.VisionMultimodalContentItemFile?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ZAI.VisionMultimodalContentItemFile?(VisionMultimodalContentItem @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public VisionMultimodalContentItem(global::ZAI.VisionMultimodalContentItemFile? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VisionMultimodalContentItem FromFile(global::ZAI.VisionMultimodalContentItemFile? value) => new VisionMultimodalContentItem(value);

        /// <summary>
        /// 
        /// </summary>
        public VisionMultimodalContentItem(
            global::ZAI.VisionMultimodalContentItemText? text,
            global::ZAI.VisionMultimodalContentItemImage? image,
            global::ZAI.VisionMultimodalContentItemVideo? video,
            global::ZAI.VisionMultimodalContentItemFile? file
            )
        {
            Text = text;
            Image = image;
            Video = video;
            File = file;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            File as object ??
            Video as object ??
            Image as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Image?.ToString() ??
            Video?.ToString() ??
            File?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage && !IsVideo && !IsFile || !IsText && IsImage && !IsVideo && !IsFile || !IsText && !IsImage && IsVideo && !IsFile || !IsText && !IsImage && !IsVideo && IsFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ZAI.VisionMultimodalContentItemText, TResult>? text = null,
            global::System.Func<global::ZAI.VisionMultimodalContentItemImage, TResult>? image = null,
            global::System.Func<global::ZAI.VisionMultimodalContentItemVideo, TResult>? video = null,
            global::System.Func<global::ZAI.VisionMultimodalContentItemFile, TResult>? file = null,
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
            global::System.Action<global::ZAI.VisionMultimodalContentItemText>? text = null,

            global::System.Action<global::ZAI.VisionMultimodalContentItemImage>? image = null,

            global::System.Action<global::ZAI.VisionMultimodalContentItemVideo>? video = null,

            global::System.Action<global::ZAI.VisionMultimodalContentItemFile>? file = null,
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
            global::System.Action<global::ZAI.VisionMultimodalContentItemText>? text = null,
            global::System.Action<global::ZAI.VisionMultimodalContentItemImage>? image = null,
            global::System.Action<global::ZAI.VisionMultimodalContentItemVideo>? video = null,
            global::System.Action<global::ZAI.VisionMultimodalContentItemFile>? file = null,
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
                typeof(global::ZAI.VisionMultimodalContentItemText),
                Image,
                typeof(global::ZAI.VisionMultimodalContentItemImage),
                Video,
                typeof(global::ZAI.VisionMultimodalContentItemVideo),
                File,
                typeof(global::ZAI.VisionMultimodalContentItemFile),
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
        public bool Equals(VisionMultimodalContentItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ZAI.VisionMultimodalContentItemText?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::ZAI.VisionMultimodalContentItemImage?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::ZAI.VisionMultimodalContentItemVideo?>.Default.Equals(Video, other.Video) &&
                global::System.Collections.Generic.EqualityComparer<global::ZAI.VisionMultimodalContentItemFile?>.Default.Equals(File, other.File) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VisionMultimodalContentItem obj1, VisionMultimodalContentItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VisionMultimodalContentItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VisionMultimodalContentItem obj1, VisionMultimodalContentItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VisionMultimodalContentItem o && Equals(o);
        }
    }
}
