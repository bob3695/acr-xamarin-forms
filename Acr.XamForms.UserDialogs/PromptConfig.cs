﻿using System;


namespace Acr.XamForms.UserDialogs {

    public enum PromptType {
        SingleLine,
        MultiLine,
        Secure
    }


    public class PromptConfig {

        public string Title { get; set; }
        public string Message { get; set; }
        public Action<PromptResult> OnResult { get; set; }

        // TODO: can cancel
        public string OkText { get; set; }
        public string CancelText { get; set; }
        public string Placeholder { get; set; }
        public PromptType Type { get; set; }


        public PromptConfig() {
            this.OkText = "OK";
            this.CancelText = "Cancel";
            this.Type = PromptType.SingleLine;
        }


        //public static PromptConfig Create(string message, Action<PromptResult> onResult) {
        //    return new PromptConfig {
        //        Message = message,
        //        OnResult = onResult
        //    };
        //}


        public PromptConfig SetTitle(string title) {
            this.Title = title;
            return this;
        }


        public PromptConfig SetMessage(string message) {
            this.Message = message;
            return this;
        }


        public PromptConfig SetOkText(string text) {
            this.OkText = text;
            return this;
        }


        public PromptConfig SetCancelText(string cancelText) {
            this.CancelText = cancelText;
            return this;
        }


        public PromptConfig SetPlaceholder(string placeholder) {
            this.Placeholder = placeholder;
            return this;
        }

        public PromptConfig SetType(PromptType type) {
            this.Type = type;
            return this;
        }
    }
}
