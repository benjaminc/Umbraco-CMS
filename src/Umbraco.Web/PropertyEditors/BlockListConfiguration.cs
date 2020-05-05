﻿using Newtonsoft.Json;
using Umbraco.Core.PropertyEditors;

namespace Umbraco.Web.PropertyEditors
{

    /// <summary>
    /// The configuration object for the Block List editor
    /// </summary>
    public class BlockListConfiguration
    {

        [ConfigurationField("blocks", "Available Blocks", "views/propertyeditors/blocklist/prevalue/blocklist.blockconfiguration.html", Description = "Define the available blocks.")]
        public BlockConfiguration[] Blocks { get; set; }


        [ConfigurationField("validationLimit", "Amount", "numberrange", Description = "Set a required range of blocks")]
        public NumberRange ValidationLimit { get; set; } = new NumberRange();

        public class NumberRange
        {
            [JsonProperty("min")]
            public int? Min { get; set; }

            [JsonProperty("max")]
            public int? Max { get; set; }
        }

        public class BlockConfiguration
        {

            [JsonProperty("backgroundColor")]
            public string BackgroundColor { get; set; }

            [JsonProperty("iconColor")]
            public string IconColor { get; set; }

            [JsonProperty("thumbnail")]
            public string Thumbnail { get; set; }

            [JsonProperty("contentTypeAlias")]
            public string Alias { get; set; }

            [JsonProperty("settingsElementTypeAlias")]
            public string SettingsElementTypeAlias { get; set; }

            [JsonProperty("view")]
            public string View { get; set; }

            [JsonProperty("stylesheet")]
            public string Stylesheet { get; set; }

            [JsonProperty("label")]
            public string Label { get; set; }

            [JsonProperty("editorSize")]
            public string EditorSize { get; set; }
        }

        [ConfigurationField("useInlineEditingAsDefault", "Inline editing mode", "boolean", Description = "Use the inline editor as the default block view.")]
        public bool UseInlineEditingAsDefault { get; set; }

        [ConfigurationField("maxPropertyWidth", "Property editor width", "textstring", Description = "optional css overwrite, example: 800px or 100%")]
        public string MaxPropertyWidth { get; set; }

    }
}
