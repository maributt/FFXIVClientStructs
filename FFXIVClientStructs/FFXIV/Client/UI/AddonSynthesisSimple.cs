using FFXIVClientStructs.FFXIV.Client.System.String;
using FFXIVClientStructs.FFXIV.Component.GUI;

namespace FFXIVClientStructs.FFXIV.Client.UI;

// Client::UI::SynthesisSimpleDialog
//   Component::GUI::AtkUnitBase
//     Component::GUI::AtkEventListener
[StructLayout(LayoutKind.Explicit, Size = 0x288)]
public unsafe struct AddonSynthesisSimple
{
    [FieldOffset(0x0)] public AtkUnitBase AtkUnitBase;
}