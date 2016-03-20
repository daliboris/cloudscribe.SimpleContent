﻿


namespace cloudscribe.SimpleContent.Models
{
    public class EditorModel
    {
        public string CurrentSlug { get; set; } = string.Empty;
        public string SavePath { get; set; } = string.Empty;
        public string EditPath { get; set; } = string.Empty;
        public string NewItemButtonText { get; set; } = "New Post";
        public string NewItemPath { get; set; } = string.Empty;
        public string DeletePath { get; set; } = string.Empty;
        public string CancelEditPath { get; set; } = string.Empty;
        public bool SupportsCategories { get; set; } = false; 
        public string CategoryPath { get; set; } = string.Empty;
        public string IndexUrl { get; set; } = string.Empty;
        public bool IsPublished { get; set; } = false;
        public string EditMode { get; set; } = "";

        public string ContentType { get; set; } = "Post";
        public int SortOrder { get; set; } = 3;
    }
}
