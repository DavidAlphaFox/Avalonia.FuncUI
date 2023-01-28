namespace Avalonia.FuncUI.DSL

[<AutoOpen>]
module Visual =
    open Avalonia
    open Avalonia.Media
    open Avalonia.FuncUI.Types
    open Avalonia.FuncUI.Builder

    type Visual with

        static member clipToBounds<'t when 't :> Visual>(value: bool) : Attr<'t> =
            AttrBuilder<'t>.CreateProperty<bool>(Visual.ClipToBoundsProperty, value, ValueNone)

        static member clip<'t when 't :> Visual>(mask: Geometry) : Attr<'t> =
            AttrBuilder<'t>.CreateProperty<Geometry>(Visual.ClipProperty, mask, ValueNone)

        static member isVisible<'t when 't :> Visual>(visible: bool) : Attr<'t> =
            AttrBuilder<'t>.CreateProperty<bool>(Visual.IsVisibleProperty, visible, ValueNone)

        static member opacity<'t when 't :> Visual>(value: float) : Attr<'t> =
            AttrBuilder<'t>.CreateProperty<float>(Visual.OpacityProperty, value, ValueNone)

        static member opacityMask<'t when 't :> Visual>(value: IBrush) : Attr<'t> =
            AttrBuilder<'t>.CreateProperty<IBrush>(Visual.OpacityMaskProperty, value, ValueNone)

        static member renderTransform<'t when 't :> Visual>(transform: ITransform) : Attr<'t> =
            AttrBuilder<'t>.CreateProperty<ITransform>(Visual.RenderTransformProperty, transform, ValueNone)

        static member renderTransformOrigin<'t when 't :> Visual>(origin: RelativePoint) : Attr<'t> =
            AttrBuilder<'t>.CreateProperty<RelativePoint>(Visual.RenderTransformOriginProperty, origin, ValueNone)

        static member zIndex<'t when 't :> Visual>(index: int) : Attr<'t> =
            AttrBuilder<'t>.CreateProperty<int>(Visual.ZIndexProperty, index, ValueNone)