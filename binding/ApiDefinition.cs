using System;
using System.Drawing;
using CoreGraphics;
using ObjCRuntime;
using Foundation;
using UIKit;

namespace WYPopover {

	// @interface WYPopoverBackgroundView : UIView
	[BaseType (typeof (UIView))]
	interface WYPopoverBackgroundView {

		// @property (nonatomic, strong) UIColor * tintColor;
		[Export ("tintColor", ArgumentSemantic.Retain)]
		[Appearance]
		UIColor TintColor { get; set; }

		// @property (nonatomic, strong) UIColor * fillTopColor;
		[Export ("fillTopColor", ArgumentSemantic.Retain)]
		[Appearance]
		UIColor FillTopColor { get; set; }

		// @property (nonatomic, strong) UIColor * fillBottomColor;
		[Export ("fillBottomColor", ArgumentSemantic.Retain)]
		[Appearance]
		UIColor FillBottomColor { get; set; }

		// @property (nonatomic, strong) UIColor * glossShadowColor;
		[Export ("glossShadowColor", ArgumentSemantic.Retain)]
		[Appearance]
		UIColor GlossShadowColor { get; set; }

		// @property (assign, nonatomic) CGSize glossShadowOffset;
		[Export ("glossShadowOffset", ArgumentSemantic.UnsafeUnretained)]
		[Appearance]
		CGSize GlossShadowOffset { get; set; }

		// @property (assign, nonatomic) NSUInteger glossShadowBlurRadius;
		[Export ("glossShadowBlurRadius", ArgumentSemantic.UnsafeUnretained)]
		[Appearance]
		uint GlossShadowBlurRadius { get; set; }

		// @property (assign, nonatomic) NSUInteger borderWidth;
		[Export ("borderWidth", ArgumentSemantic.UnsafeUnretained)]
		[Appearance]
		uint BorderWidth { get; set; }

		// @property (assign, nonatomic) NSUInteger arrowBase;
		[Export ("arrowBase", ArgumentSemantic.UnsafeUnretained)]
		[Appearance]
		uint ArrowBase { get; set; }

		// @property (assign, nonatomic) NSUInteger arrowHeight;
		[Export ("arrowHeight", ArgumentSemantic.UnsafeUnretained)]
		[Appearance]
		uint ArrowHeight { get; set; }

		// @property (nonatomic, strong) UIColor * outerShadowColor;
		[Export ("outerShadowColor", ArgumentSemantic.Retain)]
		[Appearance]
		UIColor OuterShadowColor { get; set; }

		// @property (nonatomic, strong) UIColor * outerStrokeColor;
		[Export ("outerStrokeColor", ArgumentSemantic.Retain)]
		[Appearance]
		UIColor OuterStrokeColor { get; set; }

		// @property (assign, nonatomic) NSUInteger outerShadowBlurRadius;
		[Export ("outerShadowBlurRadius", ArgumentSemantic.UnsafeUnretained)]
		[Appearance]
		uint OuterShadowBlurRadius { get; set; }

		// @property (assign, nonatomic) CGSize outerShadowOffset;
		[Export ("outerShadowOffset", ArgumentSemantic.UnsafeUnretained)]
		[Appearance]
		CGSize OuterShadowOffset { get; set; }

		// @property (assign, nonatomic) NSUInteger outerCornerRadius;
		[Export ("outerCornerRadius", ArgumentSemantic.UnsafeUnretained)]
		[Appearance]
		uint OuterCornerRadius { get; set; }

		// @property (assign, nonatomic) NSUInteger minOuterCornerRadius;
		[Export ("minOuterCornerRadius", ArgumentSemantic.UnsafeUnretained)]
		[Appearance]
		uint MinOuterCornerRadius { get; set; }

		// @property (nonatomic, strong) UIColor * innerShadowColor;
		[Export ("innerShadowColor", ArgumentSemantic.Retain)]
		[Appearance]
		UIColor InnerShadowColor { get; set; }

		// @property (nonatomic, strong) UIColor * innerStrokeColor;
		[Export ("innerStrokeColor", ArgumentSemantic.Retain)]
		[Appearance]
		UIColor InnerStrokeColor { get; set; }

		// @property (assign, nonatomic) NSUInteger innerShadowBlurRadius;
		[Export ("innerShadowBlurRadius", ArgumentSemantic.UnsafeUnretained)]
		[Appearance]
		uint InnerShadowBlurRadius { get; set; }

		// @property (assign, nonatomic) CGSize innerShadowOffset;
		[Export ("innerShadowOffset", ArgumentSemantic.UnsafeUnretained)]
		[Appearance]
		CGSize InnerShadowOffset { get; set; }

		// @property (assign, nonatomic) NSUInteger innerCornerRadius;
		[Export ("innerCornerRadius", ArgumentSemantic.UnsafeUnretained)]
		[Appearance]
		uint InnerCornerRadius { get; set; }

		// @property (assign, nonatomic) UIEdgeInsets viewContentInsets;
		[Export ("viewContentInsets", ArgumentSemantic.UnsafeUnretained)]
		[Appearance]
		UIEdgeInsets ViewContentInsets { get; set; }

		// @property (nonatomic, strong) UIColor * overlayColor;
		[Export ("overlayColor", ArgumentSemantic.Retain)]
		[Appearance]
		UIColor OverlayColor { get; set; }
	}

	// @interface WYPopoverController : NSObject <UIAppearanceContainer>
	[BaseType (typeof (UIAppearanceContainer))]
	interface WYPopoverController {

		// -(id)initWithContentViewController:(UIViewController *)viewController;
		[Export ("initWithContentViewController:")]
		IntPtr Constructor (UIViewController viewController);

		// @property (nonatomic, weak) id<WYPopoverControllerDelegate> delegate;
		[Export ("delegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, weak) id<WYPopoverControllerDelegate> delegate;
		[Wrap ("WeakDelegate")]
		WYPopoverControllerDelegate Delegate { get; set; }

		// @property (copy, nonatomic) NSArray * passthroughViews;
		[Export ("passthroughViews", ArgumentSemantic.Copy)]
		NSObject [] PassthroughViews { get; set; }

		// @property (assign, nonatomic) BOOL wantsDefaultContentAppearance;
		[Export ("wantsDefaultContentAppearance", ArgumentSemantic.UnsafeUnretained)]
		bool WantsDefaultContentAppearance { get; set; }

		// @property (assign, nonatomic) UIEdgeInsets popoverLayoutMargins;
		[Export ("popoverLayoutMargins", ArgumentSemantic.UnsafeUnretained)]
		UIEdgeInsets PopoverLayoutMargins { get; set; }

		// @property (readonly, nonatomic, getter = isPopoverVisible) BOOL popoverVisible;
		[Export ("popoverVisible")]
		bool PopoverVisible { [Bind ("isPopoverVisible")] get; }

		// @property (readonly, nonatomic, strong) UIViewController * contentViewController;
		[Export ("contentViewController", ArgumentSemantic.Retain)]
		UIViewController ContentViewController { get; }

		// @property (assign, nonatomic) CGSize popoverContentSize;
		[Export ("popoverContentSize", ArgumentSemantic.UnsafeUnretained)]
		CGSize PopoverContentSize { get; set; }

		// @property (assign, nonatomic) float animationDuration;
		[Export ("animationDuration", ArgumentSemantic.UnsafeUnretained)]
		float AnimationDuration { get; set; }

		// @property (nonatomic, strong) WYPopoverTheme * theme;
		[Export ("theme", ArgumentSemantic.Retain)]
		WYPopoverTheme Theme { get; set; }

		// +(void)setDefaultTheme:(WYPopoverTheme *)theme;
		[Static, Export ("setDefaultTheme:")]
		void SetDefaultTheme (WYPopoverTheme theme);

		// +(WYPopoverTheme *)defaultTheme;
		[Static, Export ("defaultTheme")]
		WYPopoverTheme DefaultTheme ();

		// -(void)beginThemeUpdates;
		[Export ("beginThemeUpdates")]
		void BeginThemeUpdates ();

		// -(void)endThemeUpdates;
		[Export ("endThemeUpdates")]
		void EndThemeUpdates ();

		// -(void)presentPopoverFromRect:(CGRect)rect inView:(UIView *)view permittedArrowDirections:(WYPopoverArrowDirection)arrowDirections animated:(BOOL)animated;
		[Export ("presentPopoverFromRect:inView:permittedArrowDirections:animated:")]
		void PresentPopoverFromRect (CGRect rect, UIView view, WYPopoverArrowDirection arrowDirections, bool animated);

		// -(void)presentPopoverFromRect:(CGRect)rect inView:(UIView *)view permittedArrowDirections:(WYPopoverArrowDirection)arrowDirections animated:(BOOL)animated completion:(void (^)(void))completion;
		[Export ("presentPopoverFromRect:inView:permittedArrowDirections:animated:completion:")]
		void PresentPopoverFromRect (CGRect rect, UIView view, WYPopoverArrowDirection arrowDirections, bool animated, Action completion);

		// -(void)presentPopoverFromRect:(CGRect)rect inView:(UIView *)view permittedArrowDirections:(WYPopoverArrowDirection)arrowDirections animated:(BOOL)animated options:(WYPopoverAnimationOptions)options;
		[Export ("presentPopoverFromRect:inView:permittedArrowDirections:animated:options:")]
		void PresentPopoverFromRect (CGRect rect, UIView view, WYPopoverArrowDirection arrowDirections, bool animated, WYPopoverAnimationOptions options);

		// -(void)presentPopoverFromRect:(CGRect)rect inView:(UIView *)view permittedArrowDirections:(WYPopoverArrowDirection)arrowDirections animated:(BOOL)animated options:(WYPopoverAnimationOptions)options completion:(void (^)(void))completion;
		[Export ("presentPopoverFromRect:inView:permittedArrowDirections:animated:options:completion:")]
		void PresentPopoverFromRect (CGRect rect, UIView view, WYPopoverArrowDirection arrowDirections, bool animated, WYPopoverAnimationOptions options, Action completion);

		// -(void)presentPopoverFromBarButtonItem:(UIBarButtonItem *)item permittedArrowDirections:(WYPopoverArrowDirection)arrowDirections animated:(BOOL)animated;
		[Export ("presentPopoverFromBarButtonItem:permittedArrowDirections:animated:")]
		void PresentPopoverFromBarButtonItem (UIBarButtonItem item, WYPopoverArrowDirection arrowDirections, bool animated);

		// -(void)presentPopoverFromBarButtonItem:(UIBarButtonItem *)item permittedArrowDirections:(WYPopoverArrowDirection)arrowDirections animated:(BOOL)animated completion:(void (^)(void))completion;
		[Export ("presentPopoverFromBarButtonItem:permittedArrowDirections:animated:completion:")]
		void PresentPopoverFromBarButtonItem (UIBarButtonItem item, WYPopoverArrowDirection arrowDirections, bool animated, Action completion);

		// -(void)presentPopoverFromBarButtonItem:(UIBarButtonItem *)item permittedArrowDirections:(WYPopoverArrowDirection)arrowDirections animated:(BOOL)animated options:(WYPopoverAnimationOptions)options;
		[Export ("presentPopoverFromBarButtonItem:permittedArrowDirections:animated:options:")]
		void PresentPopoverFromBarButtonItem (UIBarButtonItem item, WYPopoverArrowDirection arrowDirections, bool animated, WYPopoverAnimationOptions options);

		// -(void)presentPopoverFromBarButtonItem:(UIBarButtonItem *)item permittedArrowDirections:(WYPopoverArrowDirection)arrowDirections animated:(BOOL)animated options:(WYPopoverAnimationOptions)options completion:(void (^)(void))completion;
		[Export ("presentPopoverFromBarButtonItem:permittedArrowDirections:animated:options:completion:")]
		void PresentPopoverFromBarButtonItem (UIBarButtonItem item, WYPopoverArrowDirection arrowDirections, bool animated, WYPopoverAnimationOptions options, Action completion);

		// -(void)presentPopoverAsDialogAnimated:(BOOL)animated;
		[Export ("presentPopoverAsDialogAnimated:")]
		void PresentPopoverAsDialogAnimated (bool animated);

		// -(void)presentPopoverAsDialogAnimated:(BOOL)animated completion:(void (^)(void))completion;
		[Export ("presentPopoverAsDialogAnimated:completion:")]
		void PresentPopoverAsDialogAnimated (bool animated, Action completion);

		// -(void)presentPopoverAsDialogAnimated:(BOOL)animated options:(WYPopoverAnimationOptions)options;
		[Export ("presentPopoverAsDialogAnimated:options:")]
		void PresentPopoverAsDialogAnimated (bool animated, WYPopoverAnimationOptions options);

		// -(void)presentPopoverAsDialogAnimated:(BOOL)animated options:(WYPopoverAnimationOptions)options completion:(void (^)(void))completion;
		[Export ("presentPopoverAsDialogAnimated:options:completion:")]
		void PresentPopoverAsDialogAnimated (bool animated, WYPopoverAnimationOptions options, Action completion);

		// -(void)dismissPopoverAnimated:(BOOL)animated;
		[Export ("dismissPopoverAnimated:")]
		void DismissPopoverAnimated (bool animated);

		// -(void)dismissPopoverAnimated:(BOOL)animated completion:(void (^)(void))completion;
		[Export ("dismissPopoverAnimated:completion:")]
		void DismissPopoverAnimated (bool animated, Action completion);

		// -(void)dismissPopoverAnimated:(BOOL)animated options:(WYPopoverAnimationOptions)aOptions;
		[Export ("dismissPopoverAnimated:options:")]
		void DismissPopoverAnimated (bool animated, WYPopoverAnimationOptions aOptions);

		// -(void)dismissPopoverAnimated:(BOOL)animated options:(WYPopoverAnimationOptions)aOptions completion:(void (^)(void))completion;
		[Export ("dismissPopoverAnimated:options:completion:")]
		void DismissPopoverAnimated (bool animated, WYPopoverAnimationOptions aOptions, Action completion);
	}

	// @protocol WYPopoverControllerDelegate <NSObject>
	[BaseType (typeof (NSObject))]
	[Model]
	interface WYPopoverControllerDelegate {

		// @optional -(BOOL)popoverControllerShouldDismissPopover:(WYPopoverController *)popoverController;
		[Export ("popoverControllerShouldDismissPopover:")]
		bool PopoverControllerShouldDismissPopover (WYPopoverController popoverController);

		// @optional -(void)popoverControllerDidPresentPopover:(WYPopoverController *)popoverController;
		[Export ("popoverControllerDidPresentPopover:")]
		void PopoverControllerDidPresentPopover (WYPopoverController popoverController);

		// @optional -(void)popoverControllerDidDismissPopover:(WYPopoverController *)popoverController;
		[Export ("popoverControllerDidDismissPopover:")]
		void PopoverControllerDidDismissPopover (WYPopoverController popoverController);

		// @optional -(void)popoverController:(WYPopoverController *)popoverController willRepositionPopoverToRect:(CGRect *)rect inView:(UIView **)view;
		[Export ("popoverController:willRepositionPopoverToRect:inView:")]
		void WillRepositionPopoverToRect (WYPopoverController popoverController, CGRect rect, out UIView view);

		// @optional -(BOOL)popoverControllerShouldIgnoreKeyboardBounds:(WYPopoverController *)popoverController;
		[Export ("popoverControllerShouldIgnoreKeyboardBounds:")]
		bool PopoverControllerShouldIgnoreKeyboardBounds (WYPopoverController popoverController);

		// @optional -(void)popoverController:(WYPopoverController *)popoverController willTranslatePopoverWithYOffset:(float *)value;
		[Export ("popoverController:willTranslatePopoverWithYOffset:")]
		void WillTranslatePopoverWithYOffset (WYPopoverController popoverController, float value);
	}

	// @interface WYPopoverTheme : NSObject
	[BaseType (typeof (NSObject))]
	interface WYPopoverTheme {

		// @property (nonatomic, strong) UIColor * tintColor;
		[Export ("tintColor", ArgumentSemantic.Retain)]
		UIColor TintColor { get; set; }

		// @property (nonatomic, strong) UIColor * fillTopColor;
		[Export ("fillTopColor", ArgumentSemantic.Retain)]
		UIColor FillTopColor { get; set; }

		// @property (nonatomic, strong) UIColor * fillBottomColor;
		[Export ("fillBottomColor", ArgumentSemantic.Retain)]
		UIColor FillBottomColor { get; set; }

		// @property (nonatomic, strong) UIColor * glossShadowColor;
		[Export ("glossShadowColor", ArgumentSemantic.Retain)]
		UIColor GlossShadowColor { get; set; }

		// @property (assign, nonatomic) CGSize glossShadowOffset;
		[Export ("glossShadowOffset", ArgumentSemantic.UnsafeUnretained)]
		CGSize GlossShadowOffset { get; set; }

		// @property (assign, nonatomic) NSUInteger glossShadowBlurRadius;
		[Export ("glossShadowBlurRadius", ArgumentSemantic.UnsafeUnretained)]
		uint GlossShadowBlurRadius { get; set; }

		// @property (assign, nonatomic) NSUInteger borderWidth;
		[Export ("borderWidth", ArgumentSemantic.UnsafeUnretained)]
		uint BorderWidth { get; set; }

		// @property (assign, nonatomic) NSUInteger arrowBase;
		[Export ("arrowBase", ArgumentSemantic.UnsafeUnretained)]
		uint ArrowBase { get; set; }

		// @property (assign, nonatomic) NSUInteger arrowHeight;
		[Export ("arrowHeight", ArgumentSemantic.UnsafeUnretained)]
		uint ArrowHeight { get; set; }

		// @property (nonatomic, strong) UIColor * outerShadowColor;
		[Export ("outerShadowColor", ArgumentSemantic.Retain)]
		UIColor OuterShadowColor { get; set; }

		// @property (nonatomic, strong) UIColor * outerStrokeColor;
		[Export ("outerStrokeColor", ArgumentSemantic.Retain)]
		UIColor OuterStrokeColor { get; set; }

		// @property (assign, nonatomic) NSUInteger outerShadowBlurRadius;
		[Export ("outerShadowBlurRadius", ArgumentSemantic.UnsafeUnretained)]
		uint OuterShadowBlurRadius { get; set; }

		// @property (assign, nonatomic) CGSize outerShadowOffset;
		[Export ("outerShadowOffset", ArgumentSemantic.UnsafeUnretained)]
		CGSize OuterShadowOffset { get; set; }

		// @property (assign, nonatomic) NSUInteger outerCornerRadius;
		[Export ("outerCornerRadius", ArgumentSemantic.UnsafeUnretained)]
		uint OuterCornerRadius { get; set; }

		// @property (assign, nonatomic) NSUInteger minOuterCornerRadius;
		[Export ("minOuterCornerRadius", ArgumentSemantic.UnsafeUnretained)]
		uint MinOuterCornerRadius { get; set; }

		// @property (nonatomic, strong) UIColor * innerShadowColor;
		[Export ("innerShadowColor", ArgumentSemantic.Retain)]
		UIColor InnerShadowColor { get; set; }

		// @property (nonatomic, strong) UIColor * innerStrokeColor;
		[Export ("innerStrokeColor", ArgumentSemantic.Retain)]
		UIColor InnerStrokeColor { get; set; }

		// @property (assign, nonatomic) NSUInteger innerShadowBlurRadius;
		[Export ("innerShadowBlurRadius", ArgumentSemantic.UnsafeUnretained)]
		uint InnerShadowBlurRadius { get; set; }

		// @property (assign, nonatomic) CGSize innerShadowOffset;
		[Export ("innerShadowOffset", ArgumentSemantic.UnsafeUnretained)]
		CGSize InnerShadowOffset { get; set; }

		// @property (assign, nonatomic) NSUInteger innerCornerRadius;
		[Export ("innerCornerRadius", ArgumentSemantic.UnsafeUnretained)]
		uint InnerCornerRadius { get; set; }

		// @property (assign, nonatomic) UIEdgeInsets viewContentInsets;
		[Export ("viewContentInsets", ArgumentSemantic.UnsafeUnretained)]
		UIEdgeInsets ViewContentInsets { get; set; }

		// @property (nonatomic, strong) UIColor * overlayColor;
		[Export ("overlayColor", ArgumentSemantic.Retain)]
		UIColor OverlayColor { get; set; }

		// +(instancetype)theme;
		[Static, Export ("theme")]
		WYPopoverTheme Theme ();

		// +(instancetype)themeForIOS6;
		[Static, Export ("themeForIOS6")]
		WYPopoverTheme ThemeForIOS6 ();

		// +(instancetype)themeForIOS7;
		[Static, Export ("themeForIOS7")]
		WYPopoverTheme ThemeForIOS7 ();
	}

	// @interface WYStoryboardPopoverSegue : UIStoryboardSegue
	[BaseType (typeof (UIStoryboardSegue))]
	interface WYStoryboardPopoverSegue {

		// -(WYPopoverController *)popoverControllerWithSender:(id)sender permittedArrowDirections:(WYPopoverArrowDirection)arrowDirections animated:(BOOL)animated;
		[Export ("popoverControllerWithSender:permittedArrowDirections:animated:")]
		WYPopoverController PopoverControllerWithSender (NSObject sender, WYPopoverArrowDirection arrowDirections, bool animated);

		// -(WYPopoverController *)popoverControllerWithSender:(id)sender permittedArrowDirections:(WYPopoverArrowDirection)arrowDirections animated:(BOOL)animated options:(WYPopoverAnimationOptions)options;
		[Export ("popoverControllerWithSender:permittedArrowDirections:animated:options:")]
		WYPopoverController PopoverControllerWithSender (NSObject sender, WYPopoverArrowDirection arrowDirections, bool animated, WYPopoverAnimationOptions options);
	}
}