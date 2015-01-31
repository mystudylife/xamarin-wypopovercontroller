﻿using System;
using MonoTouch.ObjCRuntime;

namespace WYPopover {

	[Native]
	[Flags]
	public enum WYPopoverArrowDirection : uint /* nuint */ {
		Up = 1U << 0,
		Down = 1U << 1,
		Left = 1U << 2,
		Right = 1U << 3,
		None = 1U << 4,
		Any = Up | Down | Left | Right,
		Unknown = (2147483647 * 2U + 1U)
	}

	[Native]
	[Flags]
	public enum WYPopoverAnimationOptions : uint /* nuint */ {
		Fade = 1U << 0,
		Scale = 1U << 1,
		FadeWithScale = Fade | Scale
	}
}