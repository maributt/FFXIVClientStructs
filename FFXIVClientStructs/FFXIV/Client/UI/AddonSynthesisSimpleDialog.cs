using FFXIVClientStructs.FFXIV.Client.System.String;
using FFXIVClientStructs.FFXIV.Component.GUI;

namespace FFXIVClientStructs.FFXIV.Client.UI;

// Client::UI::SynthesisSimpleDialog
//   Component::GUI::AtkUnitBase
//     Component::GUI::AtkEventListener
[StructLayout(LayoutKind.Explicit, Size = 0x230)]
public unsafe struct AddonSynthesisSimpleDialog
{
    [FieldOffset(0x0)] public AtkUnitBase AtkUnitBase;
}