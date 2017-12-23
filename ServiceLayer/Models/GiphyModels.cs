using Newtonsoft.Json;

namespace ServiceLayer
{

    public partial class GiphyResponseModel
    {
        [JsonProperty("data")]
        public GiphyItemModel[] Data { get; set; }

        [JsonProperty("pagination")]
        public PaginationModel Pagination { get; set; }

        [JsonProperty("meta")]
        public MetaModel Meta { get; set; }
    }

    public partial class PaginationModel
    {
        [JsonProperty("total_count")]
        public long TotalCount { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("offset")]
        public long Offset { get; set; }
    }

    public partial class MetaModel
    {
        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("response_id")]
        public string ResponseId { get; set; }
    }

    public partial class GiphyItemModel
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("bitly_gif_url")]
        public string BitlyGifUrl { get; set; }

        [JsonProperty("bitly_url")]
        public string BitlyUrl { get; set; }

        [JsonProperty("embed_url")]
        public string EmbedUrl { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("rating")]
        public string Rating { get; set; }

        [JsonProperty("content_url")]
        public string ContentUrl { get; set; }

        [JsonProperty("source_tld")]
        public string SourceTld { get; set; }

        [JsonProperty("source_post_url")]
        public string SourcePostUrl { get; set; }

        [JsonProperty("is_indexable")]
        public long IsIndexable { get; set; }

        [JsonProperty("is_sticker")]
        public long IsSticker { get; set; }

        [JsonProperty("import_datetime")]
        public string ImportDatetime { get; set; }

        [JsonProperty("trending_datetime")]
        public string TrendingDatetime { get; set; }

        [JsonProperty("images")]
        public ImagesModel Images { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public partial class ImagesModel
    {
        [JsonProperty("fixed_height_still")]
        public The480WStillModel FixedHeightStill { get; set; }

        [JsonProperty("original_still")]
        public The480WStillModel OriginalStill { get; set; }

        [JsonProperty("fixed_width")]
        public FixedHeightModel FixedWidth { get; set; }

        [JsonProperty("fixed_height_small_still")]
        public The480WStillModel FixedHeightSmallStill { get; set; }

        [JsonProperty("fixed_height_downsampled")]
        public FixedDownsampledModel FixedHeightDownsampled { get; set; }

        [JsonProperty("preview")]
        public DownsizedSmallModel Preview { get; set; }

        [JsonProperty("fixed_height_small")]
        public FixedHeightModel FixedHeightSmall { get; set; }

        [JsonProperty("downsized_still")]
        public The480WStillModel DownsizedStill { get; set; }

        [JsonProperty("downsized")]
        public The480WStillModel Downsized { get; set; }

        [JsonProperty("downsized_large")]
        public The480WStillModel DownsizedLarge { get; set; }

        [JsonProperty("fixed_width_small_still")]
        public The480WStillModel FixedWidthSmallStill { get; set; }

        [JsonProperty("preview_webp")]
        public The480WStillModel PreviewWebp { get; set; }

        [JsonProperty("fixed_width_still")]
        public The480WStillModel FixedWidthStill { get; set; }

        [JsonProperty("fixed_width_small")]
        public FixedHeightModel FixedWidthSmall { get; set; }

        [JsonProperty("downsized_small")]
        public DownsizedSmallModel DownsizedSmall { get; set; }

        [JsonProperty("fixed_width_downsampled")]
        public FixedDownsampledModel FixedWidthDownsampled { get; set; }

        [JsonProperty("downsized_medium")]
        public The480WStillModel DownsizedMedium { get; set; }

        [JsonProperty("original")]
        public FixedHeightModel Original { get; set; }

        [JsonProperty("fixed_height")]
        public FixedHeightModel FixedHeight { get; set; }

        [JsonProperty("looping")]
        public LoopingModel Looping { get; set; }

        [JsonProperty("original_mp4")]
        public DownsizedSmallModel OriginalMp4 { get; set; }

        [JsonProperty("preview_gif")]
        public The480WStillModel PreviewGif { get; set; }

        [JsonProperty("480w_still")]
        public The480WStillModel The480WStill { get; set; }
    }

    public partial class LoopingModel
    {
        [JsonProperty("mp4")]
        public string Mp4 { get; set; }

        [JsonProperty("mp4_size")]
        public string Mp4Size { get; set; }
    }

    public partial class FixedDownsampledModel
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("webp")]
        public string Webp { get; set; }

        [JsonProperty("webp_size")]
        public string WebpSize { get; set; }
    }

    public partial class FixedHeightModel
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("frames")]
        public string Frames { get; set; }

        [JsonProperty("mp4")]
        public string Mp4 { get; set; }

        [JsonProperty("mp4_size")]
        public string Mp4Size { get; set; }

        [JsonProperty("webp")]
        public string Webp { get; set; }

        [JsonProperty("webp_size")]
        public string WebpSize { get; set; }
    }

    public partial class DownsizedSmallModel
    {
        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("mp4")]
        public string Mp4 { get; set; }

        [JsonProperty("mp4_size")]
        public string Mp4Size { get; set; }
    }

    public partial class The480WStillModel
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }
    }
}
