﻿namespace CurrieTechnologies.Razor.SweetAlert2
{
    internal static class SweetAlertOptionsMixingService
    {
        internal static SweetAlertOptions Mix(SweetAlertOptions oldSettings, SweetAlertOptions newSettings)
        {
            return new SweetAlertOptions
            {
                Title = newSettings.Title ?? oldSettings.Title,
                TitleText = newSettings.TitleText ?? oldSettings.TitleText,
                Text = newSettings.Text ?? oldSettings.Text,
                Html = newSettings.Html ?? oldSettings.Html,
                Footer = newSettings.Footer ?? oldSettings.Footer,
                Icon = newSettings.Icon ?? oldSettings.Icon,
                IconHtml = newSettings.IconHtml ?? oldSettings.IconHtml,
                Backdrop = newSettings.Backdrop ?? oldSettings.Backdrop,
                Toast = newSettings.Toast ?? oldSettings.Toast,
                Target = newSettings.Target ?? oldSettings.Target,
                Input = newSettings.Input ?? oldSettings.Input,
                Width = newSettings.Width ?? oldSettings.Width,
                Padding = newSettings.Padding ?? oldSettings.Padding,
                Color = newSettings.Color ?? oldSettings.Color,
                Background = newSettings.Background ?? oldSettings.Background,
                Position = newSettings.Position ?? oldSettings.Position,
                Grow = newSettings.Grow ?? oldSettings.Grow,
                ShowClass = newSettings.ShowClass ?? oldSettings.ShowClass,
                HideClass = newSettings.HideClass ?? oldSettings.HideClass,
                CustomClass = newSettings.CustomClass ?? oldSettings.CustomClass,
                Timer = newSettings.Timer ?? oldSettings.Timer,
                TimerProgressBar = newSettings.TimerProgressBar ?? oldSettings.TimerProgressBar,
                HeightAuto = newSettings.HeightAuto ?? oldSettings.HeightAuto,
                AllowOutsideClick = newSettings.AllowOutsideClick ?? oldSettings.AllowOutsideClick,
                AllowEscapeKey = newSettings.AllowEscapeKey ?? oldSettings.AllowEscapeKey,
                AllowEnterKey = newSettings.AllowEnterKey ?? oldSettings.AllowEnterKey,
                StopKeydownPropagation = newSettings.StopKeydownPropagation ?? oldSettings.StopKeydownPropagation,
                KeydownListenerCapture = newSettings.KeydownListenerCapture ?? oldSettings.KeydownListenerCapture,
                ShowConfirmButton = newSettings.ShowConfirmButton ?? oldSettings.ShowConfirmButton,
                ShowDenyButton = newSettings.ShowDenyButton ?? oldSettings.ShowDenyButton,
                ShowCancelButton = newSettings.ShowCancelButton ?? oldSettings.ShowCancelButton,
                ConfirmButtonText = newSettings.ConfirmButtonText ?? oldSettings.ConfirmButtonText,
                DenyButtonText = newSettings.DenyButtonText ?? oldSettings.DenyButtonText,
                CancelButtonText = newSettings.CancelButtonText ?? oldSettings.CancelButtonText,
                ConfirmButtonColor = newSettings.ConfirmButtonColor ?? oldSettings.ConfirmButtonColor,
                DenyButtonColor = newSettings.DenyButtonColor ?? oldSettings.DenyButtonColor,
                CancelButtonColor = newSettings.CancelButtonColor ?? oldSettings.CancelButtonColor,
                ConfirmButtonAriaLabel = newSettings.ConfirmButtonAriaLabel ?? oldSettings.ConfirmButtonAriaLabel,
                DenyButtonAriaLabel = newSettings.DenyButtonAriaLabel ?? oldSettings.DenyButtonAriaLabel,
                CancelButtonAriaLabel = newSettings.CancelButtonAriaLabel ?? oldSettings.CancelButtonAriaLabel,
                ButtonsStyling = newSettings.ButtonsStyling ?? oldSettings.ButtonsStyling,
                ReverseButtons = newSettings.ReverseButtons ?? oldSettings.ReverseButtons,
                FocusConfirm = newSettings.FocusConfirm ?? oldSettings.FocusConfirm,
                FocusDeny = newSettings.FocusDeny ?? oldSettings.FocusDeny,
                FocusCancel = newSettings.FocusCancel ?? oldSettings.FocusCancel,
                ReturnFocus = newSettings.ReturnFocus ?? oldSettings.ReturnFocus,
                ShowCloseButton = newSettings.ShowCloseButton ?? oldSettings.ShowCloseButton,
                CloseButtonHtml = newSettings.CloseButtonHtml ?? oldSettings.CloseButtonHtml,
                CloseButtonAriaLabel = newSettings.CloseButtonAriaLabel ?? oldSettings.CloseButtonAriaLabel,
                LoaderHtml = newSettings.LoaderHtml ?? oldSettings.LoaderHtml,
                ShowLoaderOnConfirm = newSettings.ShowLoaderOnConfirm ?? oldSettings.ShowLoaderOnConfirm,
                ShowLoaderOnDeny = newSettings.ShowLoaderOnDeny ?? oldSettings.ShowLoaderOnDeny,
                PreConfirm = newSettings.PreConfirm ?? oldSettings.PreConfirm,
                PreDeny = newSettings.PreDeny ?? oldSettings.PreDeny,
                ImageUrl = newSettings.ImageUrl ?? oldSettings.ImageUrl,
                ImageWidth = newSettings.ImageWidth ?? oldSettings.ImageWidth,
                ImageHeight = newSettings.ImageHeight ?? oldSettings.ImageHeight,
                ImageAlt = newSettings.ImageAlt ?? oldSettings.ImageAlt,
                InputLabel = newSettings.InputLabel ?? oldSettings.InputLabel,
                InputPlaceholder = newSettings.InputPlaceholder ?? oldSettings.InputPlaceholder,
                InputValue = newSettings.InputValue ?? oldSettings.InputValue,
                InputOptions = newSettings.InputOptions ?? oldSettings.InputOptions,
                InputAutoFocus = newSettings.InputAutoFocus ?? oldSettings.InputAutoFocus,
                InputAutoTrim = newSettings.InputAutoTrim ?? oldSettings.InputAutoTrim,
                InputAttributes = newSettings.InputAttributes ?? oldSettings.InputAttributes,
                InputValidator = newSettings.InputValidator ?? oldSettings.InputValidator,
                ReturnInputValueOnDeny = newSettings.ReturnInputValueOnDeny ?? oldSettings.ReturnInputValueOnDeny,
                ValidationMessage = newSettings.ValidationMessage ?? oldSettings.ValidationMessage,
                ProgressSteps = newSettings.ProgressSteps ?? oldSettings.ProgressSteps,
                CurrentProgressStep = newSettings.CurrentProgressStep ?? oldSettings.CurrentProgressStep,
                ProgressStepsDistance = newSettings.ProgressStepsDistance ?? oldSettings.ProgressStepsDistance,
                WillOpen = newSettings.WillOpen ?? oldSettings.WillOpen,
                DidClose = newSettings.DidClose ?? oldSettings.DidClose,
                DidDestroy = newSettings.DidDestroy ?? oldSettings.DidDestroy,
                DidOpen = newSettings.DidOpen ?? oldSettings.DidOpen,
                WillClose = newSettings.WillClose ?? oldSettings.WillClose,
                DidRender = newSettings.DidRender ?? oldSettings.DidRender,
                ScrollbarPadding = newSettings.ScrollbarPadding ?? oldSettings.ScrollbarPadding
            };
        }
    }
}