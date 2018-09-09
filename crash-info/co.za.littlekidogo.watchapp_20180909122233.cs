S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.7
Build-Number: R732XXU2FRC1
Build-Date: 2018.03.02 17:21:30

Crash Information
Process Name: watchapp
PID: 7918
Date: 2018-09-09 12:22:33+0200
Executable File Path: /opt/usr/apps/co.za.littlekidogo.watchapp/bin/watchapp
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x4

Register Information
r0   = 0x00000004, r1   = 0x00000004
r2   = 0x00000000, r3   = 0xffffffff
r4   = 0x00000000, r5   = 0xbe8e1dd0
r6   = 0x414c0700, r7   = 0x00000004
r8   = 0x0000003c, r9   = 0x00000000
r10  = 0x414c06d8, fp   = 0xbe8e1dc4
ip   = 0xbe8e2314, sp   = 0xbe8e1858
lr   = 0x404bee8c, pc   = 0x404f40b4
cpsr = 0x60000010

Memory Information
MemTotal:   490112 KB
MemFree:     19056 KB
Buffers:     31136 KB
Cached:     151432 KB
VmPeak:      63036 KB
VmSize:      63032 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       13756 KB
VmRSS:       13756 KB
VmData:       4248 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22892 KB
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
40000000 40005000 r-xp /usr/bin/launchpad-loader
4000d000 4002a000 r-xp /lib/ld-2.13.so
40033000 40037000 r-xp /usr/lib/libsys-assert.so
40041000 40047000 r-xp /usr/lib/libappcore-efl.so.1.1
40056000 40063000 r-xp /usr/lib/libaul.so.0.1.0
4006d000 4006f000 r-xp /lib/libdl-2.13.so
40078000 4007b000 r-xp /usr/lib/libbundle.so.0.1.22
40083000 40085000 r-xp /usr/lib/libdlog.so.0.0.0
4008d000 400a1000 r-xp /lib/libpthread-2.13.so
400ac000 401e8000 r-xp /usr/lib/libelementary.so.1.7.99
401ff000 402cd000 r-xp /usr/lib/libevas.so.1.7.99
402f3000 4030a000 r-xp /usr/lib/libecore.so.1.7.99
40321000 4037f000 r-xp /usr/lib/libedje.so.1.7.99
40389000 40459000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
4045a000 40460000 r-xp /usr/lib/libprivilege-control.so.0.0.2
40468000 4046c000 r-xp /usr/lib/libsmack.so.1.0.0
40475000 4047d000 r-xp /lib/libgcc_s-4.6.so.1
4047e000 405a2000 r-xp /lib/libc-2.13.so
405b0000 405ce000 r-xp /usr/lib/libsystemd.so.0.4.0
405d8000 405e3000 r-xp /lib/libunwind.so.8.0.1
40610000 40627000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
4062f000 40659000 r-xp /usr/lib/libdbus-1.so.3.8.12
40662000 40667000 r-xp /usr/lib/libxdgmime.so.1.1.0
4066f000 40692000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
4069a000 4069b000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
406a3000 406a9000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
406b2000 4071b000 r-xp /lib/libm-2.13.so
40724000 4073d000 r-xp /usr/lib/libeet.so.1.7.99
4074e000 4078f000 r-xp /usr/lib/libeina.so.1.7.99
40798000 407ba000 r-xp /usr/lib/libecore_evas.so.1.7.99
407c3000 407c8000 r-xp /usr/lib/libecore_file.so.1.7.99
407d0000 407e1000 r-xp /usr/lib/libecore_input.so.1.7.99
407e9000 407f2000 r-xp /usr/lib/libvconf.so.0.2.45
407fa000 4084a000 r-xp /usr/lib/libecore_x.so.1.7.99
4084c000 40855000 r-xp /usr/lib/libedbus.so.1.7.99
4085d000 40877000 r-xp /usr/lib/libecore_con.so.1.7.99
40880000 40893000 r-xp /usr/lib/libfribidi.so.0.3.1
4089b000 408e0000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
408e9000 40911000 r-xp /usr/lib/libfontconfig.so.1.8.0
40912000 40968000 r-xp /usr/lib/libfreetype.so.6.11.3
40974000 409ca000 r-xp /usr/lib/libpixman-1.so.0.28.2
409d7000 409dd000 r-xp /lib/librt-2.13.so
409e6000 409ed000 r-xp /usr/lib/libembryo.so.1.7.99
409f5000 40a0c000 r-xp /usr/lib/liblua-5.1.so
40a15000 40a1b000 r-xp /usr/lib/libecore_imf.so.1.7.99
40a23000 40a24000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
40a2c000 40a5b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40a63000 40a66000 r-xp /lib/libcap.so.2.21
40a6e000 40a86000 r-xp /usr/lib/liblzma.so.5.0.3
40a8e000 40a9e000 r-xp /lib/libresolv-2.13.so
40aa2000 40b75000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40b80000 40bb4000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40bbd000 40bd7000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40bdf000 40c54000 r-xp /usr/lib/libsqlite3.so.0.8.6
40c5e000 40c60000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
40c68000 40c7e000 r-xp /lib/libz.so.1.2.5
40c86000 40ca9000 r-xp /usr/lib/libjpeg.so.8.0.2
40cc1000 40da2000 r-xp /usr/lib/libX11.so.6.3.0
40dad000 40db2000 r-xp /usr/lib/libecore_fb.so.1.7.99
40dbb000 40dbf000 r-xp /usr/lib/libecore_ipc.so.1.7.99
40dc8000 40dcb000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
40dd3000 40dda000 r-xp /usr/lib/libXcursor.so.1.0.2
40de2000 40de4000 r-xp /usr/lib/libXdamage.so.1.1.0
40dec000 40dee000 r-xp /usr/lib/libXcomposite.so.1.0.0
40df6000 40df8000 r-xp /usr/lib/libXgesture.so.7.0.0
40e00000 40e03000 r-xp /usr/lib/libXfixes.so.3.1.0
40e0b000 40e14000 r-xp /usr/lib/libXi.so.6.1.0
40e1c000 40e1d000 r-xp /usr/lib/libXinerama.so.1.0.0
40e26000 40e2c000 r-xp /usr/lib/libXrandr.so.2.2.0
40e34000 40e3a000 r-xp /usr/lib/libXrender.so.1.3.0
40e42000 40e46000 r-xp /usr/lib/libXtst.so.6.1.0
40e4e000 40e58000 r-xp /usr/lib/libXext.so.6.4.0
40e61000 40ea5000 r-xp /usr/lib/libcurl.so.4.3.0
40eae000 40ec4000 r-xp /lib/libexpat.so.1.6.0
40ece000 40ee6000 r-xp /usr/lib/libpng12.so.0.50.0
40eee000 40f0b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
40f14000 40fa8000 r-xp /usr/lib/libstdc++.so.6.0.16
40fbb000 40fbe000 r-xp /lib/libattr.so.1.1.0
40fc6000 40fc7000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
40fcf000 40fd4000 r-xp /usr/lib/libffi.so.5.0.10
40fdd000 40fdf000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
40fe7000 410b3000 r-xp /usr/lib/libxml2.so.2.7.8
410c0000 410c2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
410cb000 410cd000 r-xp /usr/lib/journal/libjournal.so.0.1.0
410d5000 410e8000 r-xp /usr/lib/libxcb.so.1.1.0
410f2000 410fb000 r-xp /usr/lib/libcares.so.2.1.0
41104000 41132000 r-xp /usr/lib/libidn.so.11.5.44
4113a000 41181000 r-xp /usr/lib/libssl.so.1.0.0
4118d000 4131f000 r-xp /usr/lib/libcrypto.so.1.0.0
41341000 41343000 r-xp /usr/lib/libiri.so
4134b000 41352000 r-xp /lib/libcrypt-2.13.so
41382000 41384000 r-xp /usr/lib/libXau.so.6.0.0
41491000 41495000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4149d000 414a5000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
414a7000 414ac000 r-xp /usr/lib/libappcore-common.so.1.1
414b4000 414b6000 r-xp /usr/lib/libiniparser.so.0
414bf000 414c1000 r-xp /opt/usr/apps/co.za.littlekidogo.watchapp/bin/watchapp
414d5000 414d9000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
414e2000 414e4000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
414ed000 414f3000 r-xp /usr/lib/libappsvc.so.0.1.0
414fb000 4151f000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
41528000 415f7000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4160d000 41617000 r-xp /lib/libnss_files-2.13.so
418b4000 418bf000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
418ca000 418eb000 r-xp /usr/lib/libefl-extension.so.0.1.0
418f3000 41905000 r-xp /usr/lib/libefl-assist.so.0.1.0
4190d000 419c5000 r-xp /usr/lib/libcairo.so.2.11200.14
419d0000 419e6000 r-xp /usr/lib/libtts.so
419ef000 41a12000 r-xp /usr/lib/libui-extension.so.0.1.0
41a1b000 41a26000 r-xp /usr/lib/libtbm.so.1.0.0
41a2e000 41a3c000 r-xp /usr/lib/libGLESv2.so.2.0
41a45000 41a46000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41a4f000 41a55000 r-xp /usr/lib/libxcb-render.so.0.0.0
41a5d000 41a60000 r-xp /usr/lib/libEGL.so.1.4
41a68000 41a6d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41a75000 41a78000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41a80000 41a81000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41a8a000 41c12000 r-xp /usr/lib/libicui18n.so.57.1
41c22000 41d28000 r-xp /usr/lib/libicuuc.so.57.1
41d3e000 41d46000 r-xp /usr/lib/libdrm.so.2.4.0
41d4e000 41d50000 r-xp /usr/lib/libdri2.so.0.0.0
41d58000 41d5e000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41d66000 41d6b000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41d73000 41d8c000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
4362d000 4364e000 r-xp /usr/lib/libexif.so.12.3.3
43661000 43663000 r-xp /usr/lib/libttrace.so.1.1
4366b000 43670000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43678000 4367e000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43687000 4368f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43697000 436b9000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
436c2000 436c9000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
436d2000 436d4000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
436dc000 436e3000 r-xp /usr/lib/libminizip.so.1.0.0
436eb000 436f8000 r-xp /usr/lib/libail.so.0.1.0
43701000 43707000 r-xp /usr/lib/libproc-stat.so.0.2.96
4370f000 43710000 r-xp /usr/lib/libresponse.so.0.2.96
43718000 4371d000 r-xp /usr/lib/libsystem.so.0.0.0
43727000 437f1000 r-xp /usr/lib/libCOREGL.so.4.0
43b22000 43b2d000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43b36000 43b3b000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43b43000 43b5a000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43c07000 43c08000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
be8c2000 be8e3000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7918)
Call Stack Count: 1
 0: strlen + 0x4 (0x404f40b4) [/lib/libc.so.6] + 0x760b4
End of Call Stack

Package Information
Package Name: co.za.littlekidogo.watchapp
Package ID : co.za.littlekidogo.watchapp
Version: 1.0.0
Package Type: rpm
App Name: watchapp
App ID: co.za.littlekidogo.watchapp
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
0 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x454ccb50 : elm_scroller] drag_child_locked_y(0)
09-09 12:22:26.860+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x454ccb50 : elm_scroller] move content x(0), y(46)
09-09 12:22:26.875+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x454ccb50 : elm_scroller] mouse move
09-09 12:22:26.875+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x454ccb50 : elm_scroller] hold(0), freeze(0)
09-09 12:22:26.875+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x454ccb50 : elm_scroller] mouse move
09-09 12:22:26.875+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x454ccb50 : elm_scroller] hold(0), freeze(0)
09-09 12:22:26.875+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x454ccb50 : elm_scroller] direction_x(0), direction_y(1)
09-09 12:22:26.875+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x454ccb50 : elm_scroller] drag_child_locked_y(0)
09-09 12:22:26.875+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x454ccb50 : elm_scroller] move content x(0), y(44)
09-09 12:22:26.885+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x454ccb50 : elm_scroller] mouse move
09-09 12:22:26.885+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x454ccb50 : elm_scroller] hold(0), freeze(0)
09-09 12:22:26.885+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x454ccb50 : elm_scroller] direction_x(0), direction_y(1)
09-09 12:22:26.885+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x454ccb50 : elm_scroller] drag_child_locked_y(0)
09-09 12:22:26.885+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x454ccb50 : elm_scroller] move content x(0), y(40)
09-09 12:22:26.900+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x454ccb50 : elm_scroller] mouse move
09-09 12:22:26.900+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x454ccb50 : elm_scroller] hold(0), freeze(0)
09-09 12:22:26.900+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x454ccb50 : elm_scroller] direction_x(0), direction_y(1)
09-09 12:22:26.900+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x454ccb50 : elm_scroller] drag_child_locked_y(0)
09-09 12:22:26.900+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x454ccb50 : elm_scroller] move content x(0), y(34)
09-09 12:22:26.910+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x454ccb50 : elm_scroller] mouse move
09-09 12:22:26.910+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x454ccb50 : elm_scroller] hold(0), freeze(0)
09-09 12:22:26.910+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x454ccb50 : elm_scroller] direction_x(0), direction_y(1)
09-09 12:22:26.910+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x454ccb50 : elm_scroller] drag_child_locked_y(0)
09-09 12:22:26.910+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x454ccb50 : elm_scroller] move content x(0), y(32)
09-09 12:22:26.925+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x454ccb50 : elm_scroller] mouse move
09-09 12:22:26.925+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x454ccb50 : elm_scroller] hold(0), freeze(0)
09-09 12:22:26.925+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x454ccb50 : elm_scroller] mouse move
09-09 12:22:26.925+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x454ccb50 : elm_scroller] hold(0), freeze(0)
09-09 12:22:26.925+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x454ccb50 : elm_scroller] direction_x(0), direction_y(1)
09-09 12:22:26.925+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x454ccb50 : elm_scroller] drag_child_locked_y(0)
09-09 12:22:26.925+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x454ccb50 : elm_scroller] move content x(0), y(32)
09-09 12:22:26.935+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x454ccb50 : elm_scroller] mouse move
09-09 12:22:26.935+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x454ccb50 : elm_scroller] hold(0), freeze(0)
09-09 12:22:26.945+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x454ccb50 : elm_scroller] mouse move
09-09 12:22:26.945+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x454ccb50 : elm_scroller] hold(0), freeze(0)
09-09 12:22:26.950+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x454ccb50 : elm_scroller] direction_x(0), direction_y(1)
09-09 12:22:26.950+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x454ccb50 : elm_scroller] drag_child_locked_y(0)
09-09 12:22:26.950+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x454ccb50 : elm_scroller] move content x(0), y(31)
09-09 12:22:26.960+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x454ccb50 : elm_scroller] mouse move
09-09 12:22:26.960+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x454ccb50 : elm_scroller] hold(0), freeze(0)
09-09 12:22:26.965+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x454ccb50 : elm_scroller] direction_x(0), direction_y(1)
09-09 12:22:26.965+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x454ccb50 : elm_scroller] drag_child_locked_y(0)
09-09 12:22:26.965+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x454ccb50 : elm_scroller] move content x(0), y(31)
09-09 12:22:26.970+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x454ccb50 : elm_scroller] mouse move
09-09 12:22:26.970+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x454ccb50 : elm_scroller] hold(0), freeze(0)
09-09 12:22:26.980+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x454ccb50 : elm_scroller] mouse move
09-09 12:22:26.980+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x454ccb50 : elm_scroller] hold(0), freeze(0)
09-09 12:22:26.985+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x454ccb50 : elm_scroller] direction_x(0), direction_y(1)
09-09 12:22:26.985+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x454ccb50 : elm_scroller] drag_child_locked_y(0)
09-09 12:22:26.985+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x454ccb50 : elm_scroller] move content x(0), y(27)
09-09 12:22:26.990+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x454ccb50 : elm_scroller] mouse move
09-09 12:22:26.990+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x454ccb50 : elm_scroller] hold(0), freeze(0)
09-09 12:22:27.000+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x454ccb50 : elm_scroller] direction_x(0), direction_y(1)
09-09 12:22:27.000+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x454ccb50 : elm_scroller] drag_child_locked_y(0)
09-09 12:22:27.000+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x454ccb50 : elm_scroller] move content x(0), y(22)
09-09 12:22:27.005+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x454ccb50 : elm_scroller] mouse move
09-09 12:22:27.005+0200 E/EFL     ( 7721): elementary<7721> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x454ccb50 : elm_scroller] hold(0), freeze(0)
09-09 12:22:27.015+0200 E/EFL     ( 7721): ecore_x<7721> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=4661530 button=1
09-09 12:22:27.225+0200 I/efl-extension( 7721): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(489) > [0x454ccb50 : elm_scroller] detent_count(0)
09-09 12:22:27.225+0200 I/efl-extension( 7721): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(490) > [0x454ccb50 : elm_scroller] pagenumber_v(0), pagenumber_h(0)
09-09 12:22:28.020+0200 E/EFL     (  404): ecore_x<404> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x2200003 time=4661530
09-09 12:22:28.020+0200 E/EFL     ( 7721): ecore_x<7721> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=4661530
09-09 12:22:28.025+0200 E/EFL     (  404): ecore_x<404> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=4661530
09-09 12:22:29.165+0200 W/KEYROUTER(  404): e_mod_main.c: DeliverDeviceKeyEvents(3164) > Deliver KeyPress. value=2669, window=0x2200003
09-09 12:22:29.165+0200 E/EFL     ( 7721): ecore_x<7721> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=4663676
09-09 12:22:29.415+0200 W/KEYROUTER(  404): e_mod_main.c: DeliverDeviceKeyEvents(3175) > Deliver KeyRelease. value=2669, window=0x2200003
09-09 12:22:29.415+0200 E/EFL     ( 7721): ecore_x<7721> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=4663927
09-09 12:22:29.420+0200 E/efl-extension( 7721): efl_extension_events.c: _eext_key_grab_rect_key_up_cb(240) > key up called
09-09 12:22:29.870+0200 W/VOICE_MEMO( 7721): wvr-stt-policy-view.c: _wvr_policy_ancs_connect_popup_cb(130) > [33m[TID:7721][0m
09-09 12:22:29.870+0200 W/VOICE_MEMO( 7721): wvr-app.c: wvr_app_exit(1055) > [33m[TID:7721][0m
09-09 12:22:29.870+0200 I/CAPI_APPFW_APPLICATION( 7721): app_main.c: ui_app_exit(715) > ui_app_exit
09-09 12:22:29.870+0200 I/CAPI_APPFW_APPLICATION( 7721): app_main.c: app_efl_exit(145) > app_efl_exit
09-09 12:22:29.870+0200 W/VOICE_MEMO( 7721): wvr-stt-policy-view.c: _wvr_policy_ancs_connect_popup_cb(130) > [33m[TID:7721][0m
09-09 12:22:29.870+0200 W/VOICE_MEMO( 7721): wvr-app.c: wvr_app_exit(1055) > [33m[TID:7721][0m
09-09 12:22:29.870+0200 I/CAPI_APPFW_APPLICATION( 7721): app_main.c: ui_app_exit(715) > ui_app_exit
09-09 12:22:29.870+0200 I/CAPI_APPFW_APPLICATION( 7721): app_main.c: app_efl_exit(145) > app_efl_exit
09-09 12:22:29.875+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 22
09-09 12:22:29.875+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(999) > app status : 4
09-09 12:22:29.880+0200 W/APP_CORE( 7721): appcore-efl.c: appcore_efl_main(1788) > power off : 0
09-09 12:22:29.885+0200 W/APP_CORE( 7721): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[2200003] -> redirected win[6006c0] for com.samsung.voicememo-c1[7721]
09-09 12:22:29.995+0200 E/APP_CORE( 7721): appcore.c: __del_vconf(453) > [FAILED]vconfkey_ignore_key_changed
09-09 12:22:30.130+0200 I/APP_CORE( 7721): appcore-efl.c: __after_loop(1232) > Legacy lifecycle: 0
09-09 12:22:30.130+0200 I/APP_CORE( 7721): appcore-efl.c: __after_loop(1234) > [APP 7721] PAUSE before termination
09-09 12:22:30.135+0200 I/CAPI_APPFW_APPLICATION( 7721): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
09-09 12:22:30.135+0200 W/VOICE_MEMO( 7721): wvr-app.c: app_pause(408) > [33m[TID:7721][0m
09-09 12:22:30.145+0200 W/VOICE_MEMO( 7721): wvr-view-manager.c: wvr_view_mgr_post_event(241) > [33m[TID:7721][!(list)] Return[0m
09-09 12:22:30.145+0200 I/CAPI_APPFW_APPLICATION( 7721): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
09-09 12:22:30.145+0200 W/VOICE_MEMO( 7721): wvr-app.c: app_terminate(335) > [33m[TID:7721][0m
09-09 12:22:30.145+0200 W/VOICE_MEMO( 7721): wvr-record-control.c: wvr_record_state_get(521) > [33m[TID:7721][!(g_rec_thread)] Return value[0m
09-09 12:22:30.145+0200 W/VOICE_MEMO( 7721): wvr-record-control.c: wvr_record_destroy(242) > [33m[TID:7721][!(g_rec_thread)] Return[0m
09-09 12:22:30.145+0200 W/VOICE_MEMO( 7721): wvr-stt-recorder.c: wvr_stt_recorder_deinit(202) > [33m[TID:7721][!(g_stt_info)] Return[0m
09-09 12:22:30.255+0200 W/VOICE_MEMO( 7721): wvr-play-control.c: wvr_play_control_stop(438) > [33m[TID:7721][!(g_play_info.handle)] Return value[0m
09-09 12:22:30.255+0200 W/VOICE_MEMO( 7721): wvr-playlist-manager.c: wvr_playlist_mgr_destroy(101) > [33m[TID:7721][!(mgr)] Return value[0m
09-09 12:22:30.260+0200 I/VOICE_MEMO( 7721): wvms-client.c: wvms_client_ipc_deinit(100) > [33m[TID:7721]port id : [0][0m
09-09 12:22:30.260+0200 E/MESSAGE_PORT( 7721): message_port.cpp: message_port_unregister_trusted_local_port(152) > [MESSAGEPORT_ERROR_INVALID_PARAMETER] Neither 0 nor negative value is allowed.
09-09 12:22:30.265+0200 W/VOICE_MEMO( 7721): wvms-client.c: wvms_client_ipc_deinit(127) > [31m[TID:7721]message_port_unregister_trusted_local_port failed : [-22]!!![0m
09-09 12:22:30.275+0200 E/CAPI_CONTENT_MEDIA_CONTENT( 7721): media_content.c: media_content_disconnect(965) > [31m[7721]mutex is NULL
09-09 12:22:30.275+0200 I/CAPI_CONTENT_MEDIA_CONTENT( 7721): media_content.c: media_content_disconnect(969) > [32m[7721]ref count changed to: 0
09-09 12:22:30.275+0200 W/VOICE_MEMO( 7721): wvr-media-info.c: wvr_media_info_disconnect(221) > [31m[TID:7721]media_content_disconnect().. [0xffffffda][0m
09-09 12:22:30.280+0200 W/VOICE_MEMO( 7721): wvr-event-handler.c: wvr_event_handler_finalize(167) > [33m[TID:7721][!(g_event_handler)] Return value[0m
09-09 12:22:30.290+0200 W/VOICE_MEMO( 7721): wvr-util.c: wvr_util_power_lock(1231) > [33m[TID:7721]release cpu power[0m
09-09 12:22:30.430+0200 W/VOICE_MEMO( 7721): wvr-samsung-log-manager.c: wvr_samsung_log_manager_deinit(133) > [33m[TID:7721][!(g_LogManager)] Return[0m
09-09 12:22:30.430+0200 I/APP_CORE( 7721): appcore-efl.c: __after_loop(1243) > [APP 7721] After terminate() callback
09-09 12:22:30.455+0200 W/AUL_PAD ( 7721): launchpad_loader.c: __at_exit_to_release_bundle(301) > __at_exit_to_release_bundle
09-09 12:22:30.470+0200 I/UXT     ( 7721): uxt_theme_private.c: uxt_theme_delete_file_monitor(1655) > deleted color config file monitor
09-09 12:22:30.470+0200 I/UXT     ( 7721): uxt_theme_private.c: uxt_theme_delete_file_monitor(1662) > deleted font config file monitor
09-09 12:22:30.470+0200 I/efl-extension( 7721): efl_extension.c: eext_mod_shutdown(46) > Shutdown
09-09 12:22:30.490+0200 I/MALI    ( 7721): egl_platform_x11.c: __egl_platform_terminate(324) > [EGL-X11] ################################################
09-09 12:22:30.490+0200 I/MALI    ( 7721): egl_platform_x11.c: __egl_platform_terminate(325) > [EGL-X11] PID=7721   close drm_fd=23 
09-09 12:22:30.490+0200 I/MALI    ( 7721): egl_platform_x11.c: __egl_platform_terminate(326) > [EGL-X11] ################################################
09-09 12:22:30.745+0200 W/STARTER (  964): pkg-monitor.c: _proc_mgr_status_cb(455) > [_proc_mgr_status_cb:455] >> P[1088] goes to (3)
09-09 12:22:30.745+0200 E/STARTER (  964): pkg-monitor.c: _proc_mgr_status_cb(457) > [_proc_mgr_status_cb:457] >>>>H(pid 1088)'s state(3)
09-09 12:22:30.760+0200 W/AUL_AMD (  509): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-09 12:22:30.760+0200 W/AUL_AMD (  509): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
09-09 12:22:30.760+0200 W/AUL     (  509): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(1088) status(fg) type(uiapp)
09-09 12:22:30.785+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 7721 pgid = 7721
09-09 12:22:30.785+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 0
09-09 12:22:30.975+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
09-09 12:22:30.985+0200 I/AUL_AMD (  509): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 7721
09-09 12:22:30.985+0200 W/AUL     (  509): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(7721)
09-09 12:22:31.080+0200 W/PROCESSMGR(  404): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(663) > [PROCESSMGR] =====================> send UpdateClock
09-09 12:22:31.080+0200 W/W_HOME  ( 1088): event_manager.c: _ecore_x_message_cb(421) > state: 1 -> 0
09-09 12:22:31.080+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
09-09 12:22:31.080+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
09-09 12:22:31.080+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
09-09 12:22:31.080+0200 W/W_HOME  ( 1088): main.c: _ecore_x_message_cb(1029) > main_info.is_win_on_top: 1
09-09 12:22:31.080+0200 W/WATCH_CORE( 1151): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
09-09 12:22:31.080+0200 I/WATCH_CORE( 1151): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
09-09 12:22:31.080+0200 I/CAPI_WATCH_APPLICATION( 1151): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-09 12:22:31.080+0200 E/watchface-loader( 1151): watchface-loader.cpp: OnAppTimeTick(812) > 
09-09 12:22:31.080+0200 I/watchface-loader( 1151): watchface-loader.cpp: OnAppTimeTick(823) > set force update!!
09-09 12:22:31.080+0200 I/watchface-viewer( 1151): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(792) > ImagesLoadingDoneSignal().Emit()
09-09 12:22:31.085+0200 W/W_INDICATOR( 1003): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
09-09 12:22:31.085+0200 W/W_INDICATOR( 1003): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
09-09 12:22:31.110+0200 W/W_HOME  ( 1088): event_manager.c: _window_visibility_cb(460) > Window [0x3600003] is now visible(0)
09-09 12:22:31.110+0200 W/W_HOME  ( 1088): event_manager.c: _window_visibility_cb(470) > state: 0 -> 1
09-09 12:22:31.110+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
09-09 12:22:31.110+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
09-09 12:22:31.115+0200 W/W_HOME  ( 1088): main.c: _window_visibility_cb(996) > Window [0x3600003] is now visible(0)
09-09 12:22:31.115+0200 I/APP_CORE( 1088): appcore-efl.c: __do_app(453) > [APP 1088] Event: RESUME State: PAUSED
09-09 12:22:31.115+0200 I/CAPI_APPFW_APPLICATION( 1088): app_main.c: app_appcore_resume(223) > app_appcore_resume
09-09 12:22:31.115+0200 W/W_HOME  ( 1088): main.c: _appcore_resume_cb(480) > appcore resume
09-09 12:22:31.115+0200 W/W_HOME  ( 1088): event_manager.c: _app_resume_cb(373) > state: 2 -> 1
09-09 12:22:31.115+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
09-09 12:22:31.120+0200 W/W_INDICATOR( 1003): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
09-09 12:22:31.120+0200 W/W_INDICATOR( 1003): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
09-09 12:22:31.120+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
09-09 12:22:31.120+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
09-09 12:22:31.120+0200 W/APPS    ( 1088): apps_main.c: _time_changed_cb(409) >  date : 9->9
09-09 12:22:31.120+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
09-09 12:22:31.120+0200 W/W_HOME  ( 1088): rotary.c: rotary_attach(138) > rotary_attach:0x47c25398
09-09 12:22:31.120+0200 I/efl-extension( 1088): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x47c25398, elm_layout, _activated_obj : 0x4607c708, activated : 1
09-09 12:22:31.120+0200 I/efl-extension( 1088): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
09-09 12:22:31.120+0200 W/W_HOME  ( 1088): win.c: win_back_gesture_disable_set(170) > disable back gesture
09-09 12:22:31.120+0200 W/W_HOME  ( 1088): win.c: win_back_gesture_disable_set(170) > disable back gesture
09-09 12:22:31.125+0200 I/wnotib  ( 1088): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 0
09-09 12:22:31.130+0200 E/wnotib  ( 1088): w-notification-board-action.c: wnb_action_is_drawer_hidden(5192) > [NULL==g_wnb_action_data] msg Drawer not initialized.
09-09 12:22:31.130+0200 W/wnotib  ( 1088): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(974) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
09-09 12:22:31.655+0200 I/MALI    ( 1088): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x43ed92d8] swap changed from async to sync
09-09 12:22:31.880+0200 W/AUL_AMD (  509): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
09-09 12:22:32.130+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:22:32.130+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:22:32.135+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:22:32.135+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 12:22:32.135+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-09 12:22:32.135+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 12:22:32.135+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
09-09 12:22:32.135+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:22:32.150+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:22:32.150+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:22:32.150+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:22:32.150+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-09 12:22:32.150+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
09-09 12:22:32.150+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 12:22:32.150+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
09-09 12:22:32.150+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-09 12:22:32.150+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-09 12:22:32.150+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:22:32.210+0200 I/efl-extension( 1242): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:22:32.210+0200 I/efl-extension( 1003): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:22:32.215+0200 I/efl-extension( 1088): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:22:32.215+0200 I/efl-extension( 1088): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x47c25398, elm_layout, time_stamp : 4666727
09-09 12:22:32.215+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: runRotaryForwardAnimation(3600) >  EditMode[0], focusPage[1], focusIndex[12], ItemListSize[15], FocusPrev[0], FocusNext[0], FocusRecent[0], HideNextPage[0]
09-09 12:22:32.215+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: runFocusAni(3491) >  nNewFocus[13], anim[0], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[15]
09-09 12:22:32.215+0200 W/APPS    ( 1088): AppsItem.cpp: aniFocusIndex(2373) >  [Galaxy Apps:13] Focused[0], focusIdx[13]
09-09 12:22:32.220+0200 W/APPS    ( 1088): AppsItem.cpp: setLastIndex(1280) >  This is last index app [14:watchapp], focusIdx[13]
09-09 12:22:32.220+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
09-09 12:22:32.220+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
09-09 12:22:32.275+0200 W/MUSIC_CONTROL_SERVICE( 1500): music-control-service.c: _music_control_service_pasre_request(565) > [33m[TID:1500]   [com.samsung.w-home]register msg port [true][0m
09-09 12:22:32.275+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 14
09-09 12:22:32.290+0200 W/AUL_AMD (  509): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 1088
09-09 12:22:32.300+0200 W/MUSIC_CONTROL_SERVICE( 1500): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1500]   [MUSIC_PLAYER_EVENT][0m
09-09 12:22:32.305+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1500): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
09-09 12:22:32.305+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1500): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
09-09 12:22:32.305+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1500): preference.c: preference_get_int(1132) > preference_get_int(1500) : key(music-control-service_native/playing_diration) error
09-09 12:22:32.305+0200 W/MUSIC_CONTROL_SERVICE( 1500): music-control-info.c: music_control_info_get_player_position(626) > [31m[TID:1500]   preference_get_int() .. [0xfef00030][0m
09-09 12:22:32.305+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:22:32.305+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:22:32.305+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:22:32.305+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 12:22:32.305+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-09 12:22:32.305+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 12:22:32.305+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
09-09 12:22:32.305+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:22:32.310+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:22:32.310+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:22:32.310+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:22:32.310+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-09 12:22:32.310+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
09-09 12:22:32.310+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 12:22:32.310+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
09-09 12:22:32.310+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-09 12:22:32.310+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-09 12:22:32.310+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:22:32.315+0200 W/MUSIC_CONTROL_SERVICE( 1500): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1500]   [MUSIC_PLAYER_EVENT][0m
09-09 12:22:32.315+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1500): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
09-09 12:22:32.320+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1500): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
09-09 12:22:32.320+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1500): preference.c: preference_get_int(1132) > preference_get_int(1500) : key(music-control-service_native/playing_diration) error
09-09 12:22:32.320+0200 W/MUSIC_CONTROL_SERVICE( 1500): music-control-info.c: music_control_info_get_player_position(626) > [31m[TID:1500]   preference_get_int() .. [0xfef00030][0m
09-09 12:22:32.320+0200 W/W_HOME  ( 1088): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
09-09 12:22:32.320+0200 E/W_HOME  ( 1088): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
09-09 12:22:32.320+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:22:32.320+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:22:32.320+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:22:32.320+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 12:22:32.320+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-09 12:22:32.320+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 12:22:32.320+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
09-09 12:22:32.320+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:22:32.325+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:22:32.325+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:22:32.325+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:22:32.325+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-09 12:22:32.325+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
09-09 12:22:32.325+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 12:22:32.325+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
09-09 12:22:32.325+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-09 12:22:32.325+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-09 12:22:32.325+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:22:32.335+0200 I/TIZEN_N_SOUND_MANAGER( 1500): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000225
09-09 12:22:32.335+0200 E/TIZEN_N_SOUND_MANAGER( 1500): sound_manager_private.c: __convert_sound_manager_error_code(158) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000225)
09-09 12:22:32.335+0200 W/MUSIC_CONTROL_SERVICE( 1500): music-control-sound-manager.c: music_control_sound_mgr_get_volume(109) > [31m[TID:1500]   sound_manager_get_volume() .. [0xfe6a0001][0m
09-09 12:22:32.335+0200 W/W_HOME  ( 1088): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
09-09 12:22:32.335+0200 E/W_HOME  ( 1088): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
09-09 12:22:32.335+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:22:32.335+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:22:32.335+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:22:32.335+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 12:22:32.335+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-09 12:22:32.335+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 12:22:32.335+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
09-09 12:22:32.335+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:22:32.335+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:22:32.335+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:22:32.335+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:22:32.335+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-09 12:22:32.335+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
09-09 12:22:32.335+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 12:22:32.335+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
09-09 12:22:32.335+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-09 12:22:32.335+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-09 12:22:32.335+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:22:32.350+0200 I/efl-extension( 1003): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:22:32.350+0200 I/efl-extension( 1242): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:22:32.355+0200 I/efl-extension( 1088): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:22:32.355+0200 I/efl-extension( 1088): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x47c25398, elm_layout, time_stamp : 4666866
09-09 12:22:32.355+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: runRotaryForwardAnimation(3600) >  EditMode[0], focusPage[1], focusIndex[13], ItemListSize[15], FocusPrev[0], FocusNext[0], FocusRecent[0], HideNextPage[0]
09-09 12:22:32.355+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: runFocusAni(3491) >  nNewFocus[14], anim[0], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[15]
09-09 12:22:32.355+0200 W/APPS    ( 1088): AppsItem.cpp: setLastIndex(1280) >  This is last index app [14:watchapp], focusIdx[14]
09-09 12:22:32.355+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
09-09 12:22:32.355+0200 W/APPS    ( 1088): AppsItem.cpp: aniFocusIndex(2373) >  [watchapp:14] Focused[0], focusIdx[14]
09-09 12:22:32.355+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: onAutoLaunchTimerStart(5026) >  auto launch is disabled
09-09 12:22:32.355+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
09-09 12:22:32.585+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: onAutoLaunchTimerStart(5026) >  auto launch is disabled
09-09 12:22:33.025+0200 E/EFL     ( 1088): ecore_x<1088> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=4667539 button=1
09-09 12:22:33.025+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 12:22:33.025+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 12:22:33.025+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: touchPressed(1663) >  TOUCH [128, 154]
09-09 12:22:33.030+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: onBubbleButtonEffect(2428) >  [249, 249, 249, 102]
09-09 12:22:33.030+0200 E/EFL     ( 1088): evas_main<1088> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
09-09 12:22:33.030+0200 E/EFL     ( 1088): evas_main<1088> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
09-09 12:22:33.030+0200 E/EFL     ( 1088): evas_main<1088> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
09-09 12:22:33.035+0200 E/W_HOME  ( 1088): util.c: util_is_rdu_retailmode(1530) > Cannot get the vconf for retailmode
09-09 12:22:33.055+0200 E/EFL     ( 1088): ecore_x<1088> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=4667567 button=1
09-09 12:22:33.055+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 12:22:33.055+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 12:22:33.055+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: touchReleased(1976) >  TOUCH [128, 154]->[125, 157]
09-09 12:22:33.060+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: onBubbleButtonEffect(2446) >  [249, 249, 249, 255]
09-09 12:22:33.060+0200 W/APPS    ( 1088): AppsItem.cpp: onItemClicked(478) >  onItemClicked[0,14]
09-09 12:22:33.065+0200 E/APPS    ( 1088): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
09-09 12:22:33.065+0200 W/APPS    ( 1088): AppsItem.cpp: onItemClicked(502) >  item(watchapp) launched, open(0), tts(0)
09-09 12:22:33.070+0200 W/AUL     ( 1088): launch.c: app_request_to_launchpad(284) > request cmd(0) to(co.za.littlekidogo.watchapp)
09-09 12:22:33.070+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 0
09-09 12:22:33.070+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(1782) > caller pid : 1088
09-09 12:22:33.070+0200 I/AUL_AMD (  509): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
09-09 12:22:33.080+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(2218) > pad pid(-5)
09-09 12:22:33.080+0200 W/AUL_PAD ( 1235): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
09-09 12:22:33.080+0200 W/AUL_PAD ( 1235): launchpad.c: __send_result_to_caller(272) > Check app launching
09-09 12:22:33.080+0200 W/AUL_PAD ( 7918): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
09-09 12:22:33.085+0200 W/AUL_PAD ( 7918): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
09-09 12:22:33.085+0200 W/AUL_PAD ( 7918): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
09-09 12:22:33.085+0200 W/AUL_PAD ( 7918): launchpad_loader.c: main(680) > [candidate] dlopen(co.za.littlekidogo.watchapp)
09-09 12:22:33.090+0200 E/RESOURCED(  681): block.c: block_prelaunch_state(138) > insert data co.za.littlekidogo.watchapp, table num : 3
09-09 12:22:33.135+0200 I/efl-extension( 7918): efl_extension.c: eext_mod_init(40) > Init
09-09 12:22:33.140+0200 I/UXT     ( 7918): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
09-09 12:22:33.140+0200 W/AUL_PAD ( 7918): launchpad_loader.c: main(690) > [candidate] dlsym
09-09 12:22:33.140+0200 W/AUL_PAD ( 7918): launchpad_loader.c: main(694) > [candidate] dl_main(co.za.littlekidogo.watchapp)
09-09 12:22:33.145+0200 I/CAPI_APPFW_APPLICATION( 7918): app_main.c: ui_app_main(704) > app_efl_main
09-09 12:22:33.150+0200 I/CAPI_APPFW_APPLICATION( 7918): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
09-09 12:22:33.180+0200 W/AUL     (  509): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(co.za.littlekidogo.watchapp) pid(7918) type(uiapp) bg(0)
09-09 12:22:33.185+0200 W/AUL     ( 1088): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7918)
09-09 12:22:33.185+0200 W/W_HOME  ( 1088): util.c: apps_util_launch_main_operation(785) > Launch app:[watchapp] ret:[0]
09-09 12:22:33.185+0200 W/AUL_AMD (  509): amd_status.c: __socket_monitor_cb(1277) > (7918) was created
09-09 12:22:33.185+0200 E/AUL     (  509): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
09-09 12:22:33.190+0200 W/STARTER (  964): pkg-monitor.c: _app_mgr_status_cb(400) > [_app_mgr_status_cb:400] Launch request [7918]
09-09 12:22:33.195+0200 W/W_HOME  ( 1088): util.c: send_launch_appId(620) > launch appid[co.za.littlekidogo.watchapp]
09-09 12:22:33.195+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:22:33.195+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:22:33.195+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:22:33.195+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 12:22:33.195+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-09 12:22:33.195+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 12:22:33.195+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.app-shortcut-widget:Apptray.Message.Launch.AppId]
09-09 12:22:33.195+0200 E/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
09-09 12:22:33.195+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:22:33.195+0200 E/MESSAGE_PORT( 1088): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (Apptray.Message.Launch.AppId) is not found.
09-09 12:22:33.195+0200 E/W_HOME  ( 1088): util.c: send_launch_appId(636) > There is no remote message port
09-09 12:22:33.195+0200 W/APPS    ( 1088): AppsItem.cpp: onItemClicked(536) >  appid(co.za.littlekidogo.watchapp)  pkgid(co.za.littlekidogo.watchapp), name(watchapp)
09-09 12:22:33.265+0200 E/EFL     ( 7918): ecore_evas<7918> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
09-09 12:22:33.345+0200 I/watchapp( 7918): watchapp.c: create_base_gui(82) > this is the items we want Do GTD Review
09-09 12:22:33.345+0200 I/watchapp( 7918): watchapp.c: create_base_gui(82) > this is the items we want Build Watch Prototype
09-09 12:22:33.345+0200 I/watchapp( 7918): watchapp.c: create_base_gui(82) > this is the items we want Research African Markets
09-09 12:22:33.345+0200 I/watchapp( 7918): watchapp.c: create_base_gui(82) > this is the items we want Go to Durbanville for Lunch
09-09 12:22:33.415+0200 W/CRASH_MANAGER( 7890): worker.c: worker_job(1205) > 1107918776174153648855
