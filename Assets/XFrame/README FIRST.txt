 ***********************************
*      X-FRAME FPS ACCELERATOR     *
* (C) Copyright 2016-2021 Kronnect * 
*            README FILE           *
 ***********************************


How to use this asset
---------------------

Thanks for purchasing X-Frame FPS Accelerator.

To use the asset in your project, select your camera and add the component "X-Frame FPS Accelerator" script to it.
Use the custom inspector to customize the behaviour. Many properties in the inspector shows a tooltip with some additional details.


Hints
-----

- Test results on real mobile device.
- If you experiment problems with the asset, try a different Render Method (option in X-Frame inspector).


Support
-------

* Support Forum: https://kronnect.com/support
* Our website: https://kronnect.com
* General contact email: contact@kronnect.com
* Twitter: @Kronnect


Other Cool Assets!
------------------

Check our other assets on the Asset Store publisher page:
https://assetstore.unity.com/publishers/15018



Future updates
--------------

All our assets follow an incremental development process by which a few beta releases are published on our support forum (kronnect.com).
We encourage you to signup and engage our forum. The forum is the primary support and feature discussions medium.

Of course, all updates of X-Frame FPS Accelerator will be eventually available on the Asset Store.



Version history
---------------

Current version
- New "Minimum FPS" for static camera mode
- New "Position Change Threshold" for static camera mode
- Redesigned inspector, grouping options in a better structured fashion

Version 5.0
- Minimum Unity version required is now 2020.3
- Added "Pixel Light Count Threshold" to specify the minimum resolution loss before reducing pixel lights
- [Fix] Fixed pixel light count handling issue in URP

Version 4.2
- Added LOD bias support option

Version 4.1.2
- [Fix] Fixed an issue that could change shadow distance in URP when Quality Settings distance differs from URP asset value

Version 4.1.1
- [Fix] Fixed "Nice FPS" checkbox locked in inspector

Version 4.1
- API: added UpdateCanvasUI(canvas), RestoreCanvasUI(canvas) for handling a single canvas directly
- Handles application pause/resume

Version 4.0
- X-Frame now adjust shadow distance dynamically

Version 3.9.1
- Renamed "Lightweight" to "Universal"
- Added option to print current quality level on-screen
- Updated documentation

Version 3.8
- Added "targetIsDownscaled" parameter/option to AdjustScreenPosition method.

Version 3.7
- Added "Maximum Quality" / "Starting Quality" options

Version 3.6.2
- [Fix] Fix related to Graphics Raycaster Proxy being added to Canvas components that do not need it

Version 3.6.1
- [Fix] Fixes related to split-screen setups and initialization from asset bundles

Version 3.6
- Added "Min Interval" to Manage Shadows option
- Support for background camera with new "Blend With Background" option
- [Fix] Fixed aspect ration when changing device orientation

Version 3.5
- Support for multiple cameras

Version 3.4.3
- [Fix] Fixed crash when GraphicsRayCaster component is missing from UI Canvas

Version 3.4.2
- [Fix] Fixes inspector issue with LRWP/URP

Version 3.4.1
- Added "Boost Frame Rate" option (enabled by default but can be disabled to avoid tearing artifacts)
- [Fix] Minor initialization fix

Version 3.4
- UI interaction improvements

Version 3.3.1
- [Fix] Fixed interaction with dropdown UI components

Version 3.2.7 2019-SEP-15
- [Fix] Non interactable UI elements are now ignored by GraphicsRayCasterProxy

Version 3.2.6 2019-SEP-14
- Improvements to OnPointerClick event forwarding
- [Fix] Fixed issue when forwarding OnPointerExit event

Version 3.2.4 2019-JUN-10
- Improved click handling

Version 3.2.3 2019-MAY-20
- Added compatibility with Unity 2019.1

Version 3.2.2 2019-FEB-1
- Updated compatibility with LWRP 4.1

Version 3.2.1 2019-JAN-20
- [Fix] Forced render texture release when disabling the component

Version 3.2.0 2018-12-2
- Added IsPointerOverUIElement, IsPointerOverGameObject

Version 3.1.2 2018-11-26
- Minor enhancements

Version 3.1.1 2018-08-2
- Prevent instanced camera's near clip incorrect value

Version 3.1 2018-06-15
- Added Enable Click Events to support scene gameobjects that require OnMouseDown/OnMouseUp events
- [Fix] Fixed HDR issue with Second Camera Blit mode

Version 3.0.1 2018-05-25
- [Fix] Fixed unnecessary memory allocations when X-Frame method is set to disabled

Version 3.0 2018-05-15
- Support for Lightweight Rendering Pipeline in Unity 2018.1
- Option to show FPS on screen

Version 2.3 2018-05-03
- API: Added ScreenToCameraRay function: takes into account current downsampling factor
- [Fix] Changes in X-Frame inspector were not marking scene as dirty (pending save)

Version 2.2.10 2017.12-18
- UI Canvas: Added support for UI events on canvases in World Space
- UI Canvas: Added support for OnPointerClick proxy

Version 2.2.9 2017.11.24
- Added support for Canvas UI events on canvases with Screen Space - Camera option enabled
- Removed Simple rendering mode (Unity 2017.2 and up)
- [Fix] Fixed Canvas UI scaling issue when canvas is configured as Screen Space - Camera

Version 2.2.8 2017.08.15
- [Fix] Fixed Second Camera Blit issues with Unity 2017.1

Version 2.2.7 2017.06.26
- Added user-defined camera clear flags parameter for X-Frame camera
- [Fix] Improved billboard creation so any residual billboard is reused

Version 2.2.6 2017.06.12
- [Fix] Fixed Canvas UI wrong scale with Simple compositing method

Version 2.2.5 2017.05.08
- [Fix] Fixed graphic glitch on Unity 5.6

Version 2.2.4 2017.04.15
- [Fix] Fixed regression bug which was limiting max FPS

Version 2.2.3 2017.03.17
- Improved Second Camera Blit method
- Added Prewarm option to pre-generate the render buffers at the start
- [Fix] Fixed crash with Simple Mode and Quad/Vertical downsamplers

Version 2.2.2 2017.02.26
- [Fix] Fixed stuttering on some Android devices when enabling Antialias setting

Version 2.2.1 2017.01.15
- [Fix] Fixed inspector issue when disabling non-compliant image effects
- [Fix] Fixed issue when niceFPS triggers

Version 2.2 2016.08.18
- General shader optimizations
- New downsampling parameter
- Effect can now be seen in Scene View in Unity 5.4
- Added niceFPS, adaptation speed up and adaptation speed down parameters.

Version 2.1 2016.08.05
- Two new render methods added for best compatibility (Billboard World Space and Billboard Overlay).

Version 2.0 2016.08.01
- Simplified workflow. Two render methods allowed: simple or second camera with optional sharpen pass.
- [Fix] Fixed lag spikes due to invalid antialias setting.

Version 2.0 2016.07.15:
- New filtering option (point / bilinear) for upscaling frames
- Quality setting was reset when entering into playmode
- [Fix] Fixed issue when switching cameras

Version 1.0 2016.06.14 - First release

