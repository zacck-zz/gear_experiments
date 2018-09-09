S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.7
Build-Number: R732XXU2FRC1
Build-Date: 2018.03.02 17:21:30

Crash Information
Process Name: watchapp
PID: 14616
Date: 2018-09-09 13:02:37+0200
Executable File Path: /opt/usr/apps/co.za.littlekidogo.watchapp/bin/watchapp
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x4

Register Information
r0   = 0x00000004, r1   = 0x00000004
r2   = 0x00000000, r3   = 0xffffffff
r4   = 0x00000000, r5   = 0xbeb8edc8
r6   = 0x413c0771, r7   = 0x00000004
r8   = 0x00000029, r9   = 0x00000000
r10  = 0x413c075c, fp   = 0xbeb8edbc
ip   = 0xbeb8f30c, sp   = 0xbeb8e850
lr   = 0x404bee8c, pc   = 0x404f40b4
cpsr = 0x60000010

Memory Information
MemTotal:   490112 KB
MemFree:      4924 KB
Buffers:     26256 KB
Cached:     142348 KB
VmPeak:      63220 KB
VmSize:      63216 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       13712 KB
VmRSS:       13712 KB
VmData:       4432 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22892 KB
VmPTE:          42 KB
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
41391000 41395000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4139d000 413a5000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
413a7000 413ac000 r-xp /usr/lib/libappcore-common.so.1.1
413b4000 413b6000 r-xp /usr/lib/libiniparser.so.0
413bf000 413c1000 r-xp /opt/usr/apps/co.za.littlekidogo.watchapp/bin/watchapp
413d5000 413d9000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
413e2000 413e4000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
413ed000 413f3000 r-xp /usr/lib/libappsvc.so.0.1.0
413fb000 4141f000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
41428000 414f7000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4150d000 41517000 r-xp /lib/libnss_files-2.13.so
416b4000 416bf000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
416ca000 416eb000 r-xp /usr/lib/libefl-extension.so.0.1.0
416f3000 41705000 r-xp /usr/lib/libefl-assist.so.0.1.0
4170d000 417c5000 r-xp /usr/lib/libcairo.so.2.11200.14
417d0000 417e6000 r-xp /usr/lib/libtts.so
417ef000 41812000 r-xp /usr/lib/libui-extension.so.0.1.0
4181b000 41826000 r-xp /usr/lib/libtbm.so.1.0.0
4182e000 4183c000 r-xp /usr/lib/libGLESv2.so.2.0
41845000 41846000 r-xp /usr/lib/libxcb-shm.so.0.0.0
4184f000 41855000 r-xp /usr/lib/libxcb-render.so.0.0.0
4185d000 41860000 r-xp /usr/lib/libEGL.so.1.4
41868000 4186d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
4187c000 419a9000 rw-p [heap]
419a9000 419ac000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
419b4000 419b5000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
419be000 41b46000 r-xp /usr/lib/libicui18n.so.57.1
41b56000 41c5c000 r-xp /usr/lib/libicuuc.so.57.1
41c72000 41c7a000 r-xp /usr/lib/libdrm.so.2.4.0
41c82000 41c84000 r-xp /usr/lib/libdri2.so.0.0.0
41c8c000 41c92000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41c9a000 41c9f000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41ca7000 41cc0000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
43561000 43582000 r-xp /usr/lib/libexif.so.12.3.3
43595000 43597000 r-xp /usr/lib/libttrace.so.1.1
4359f000 435a4000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
435ac000 435b2000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
435bb000 435c3000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
435cb000 435ed000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
435f6000 435fd000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43606000 43608000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43610000 43617000 r-xp /usr/lib/libminizip.so.1.0.0
4361f000 4362c000 r-xp /usr/lib/libail.so.0.1.0
43635000 4363b000 r-xp /usr/lib/libproc-stat.so.0.2.96
43643000 43644000 r-xp /usr/lib/libresponse.so.0.2.96
4364c000 43651000 r-xp /usr/lib/libsystem.so.0.0.0
4365b000 43725000 r-xp /usr/lib/libCOREGL.so.4.0
43a56000 43a61000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43a6a000 43a6f000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43a77000 43a8e000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43c34000 43c35000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
beb6f000 beb90000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14616)
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
neIdlerCb(792) > ImagesLoadingDoneSignal().Emit()
09-09 13:02:29.088+0200 W/STARTER (  964): hw_key.c: _powerkey_timer_cb(946) > [_powerkey_timer_cb:946] _powerkey_timer_cb, powerkey count[1]
09-09 13:02:29.133+0200 W/STARTER (  964): hw_key.c: _powerkey_timer_cb(1165) > [_powerkey_timer_cb:1165] clock visibility[1] pressed lcd status[1], current lcd status[1] pressed pm state[1]
09-09 13:02:29.193+0200 E/STARTER (  964): dbus-util.c: dbus_request_cpu_boost(292) > [dbus_request_cpu_boost:292] failed to _invoke_dbus_method_sync
09-09 13:02:29.193+0200 W/AUL     (  964): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-home)
09-09 13:02:29.193+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 0
09-09 13:02:29.198+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(1782) > caller pid : 964
09-09 13:02:29.198+0200 I/CAPI_WATCH_APPLICATION( 1151): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-09 13:02:29.198+0200 E/watchface-loader( 1151): watchface-loader.cpp: OnAppTimeTick(812) > 
09-09 13:02:29.203+0200 W/AUL     (  509): app_signal.c: aul_send_app_resume_request_signal(567) > aul_send_app_resume_request_signal app(com.samsung.w-home) pid(1088) type(uiapp) bg(0)
09-09 13:02:29.203+0200 W/AUL_AMD (  509): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 1088
09-09 13:02:29.213+0200 E/AUL     (  509): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
09-09 13:02:29.218+0200 W/AUL_AMD (  509): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(1088), cmd(0)
09-09 13:02:29.218+0200 W/AUL     (  964): launch.c: app_request_to_launchpad(298) > request cmd(0) result(1088)
09-09 13:02:29.218+0200 W/STARTER (  964): pkg-monitor.c: _app_mgr_status_cb(421) > [_app_mgr_status_cb:421] Resume request [1088]
09-09 13:02:29.223+0200 I/APP_CORE( 1088): appcore-efl.c: __do_app(453) > [APP 1088] Event: RESET State: RUNNING
09-09 13:02:29.223+0200 I/CAPI_APPFW_APPLICATION( 1088): app_main.c: app_appcore_reset(245) > app_appcore_reset
09-09 13:02:29.223+0200 W/CAPI_APPFW_APP_CONTROL( 1088): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
09-09 13:02:29.223+0200 E/W_HOME  ( 1088): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
09-09 13:02:29.223+0200 W/W_HOME  ( 1088): main.c: _app_control_progress(1606) > Service value : powerkey
09-09 13:02:29.223+0200 W/wnotib  ( 1088): w-notification-board-broker-main.c: _wnb_handle_view_event(1290) > Home view event: 0x40001
09-09 13:02:29.223+0200 E/wnotib  ( 1088): w-notification-board-action.c: wnb_action_is_popup_shown(5116) > [NULL==g_wnb_action_data] msg Drawer not initialized.
09-09 13:02:29.228+0200 E/wnotib  ( 1088): w-notification-board-action.c: wnb_action_is_drawer_hidden(5192) > [NULL==g_wnb_action_data] msg Drawer not initialized.
09-09 13:02:29.228+0200 W/wnotib  ( 1088): w-notification-board-broker-main.c: wnb_dismiss_confirmation_popup(1406) > 
09-09 13:02:29.228+0200 W/W_HOME  ( 1088): noti_broker.c: _noti_broker_home_cb(786) > continue the home key execution
09-09 13:02:29.228+0200 E/W_HOME  ( 1088): cs_broker.c: _cs_broker_home_cb(274) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
09-09 13:02:29.228+0200 W/W_HOME  ( 1088): main.c: _home_key_cb(1504) > Home Key operation tutorial:0 window:1 clock:1 apps:0 is_app_resumed:1 is_tts:0
09-09 13:02:29.233+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:1 apptray-visibility:0 apptray-edit_visibility:0
09-09 13:02:29.233+0200 W/W_HOME  ( 1088): move.c: move_move_to_apps(219) > move to apps
09-09 13:02:29.238+0200 W/W_HOME  ( 1088): rotary.c: rotary_attach(138) > rotary_attach:0x4880b248
09-09 13:02:29.238+0200 I/efl-extension( 1088): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4880b248, elm_layout, _activated_obj : 0x4607c708, activated : 1
09-09 13:02:29.238+0200 I/efl-extension( 1088): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
09-09 13:02:29.238+0200 W/W_HOME  ( 1088): event_manager.c: _move_module_anim_start_cb(660) > state: 0 -> 1
09-09 13:02:29.238+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 13:02:29.243+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 13:02:29.243+0200 W/W_INDICATOR( 1003): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
09-09 13:02:29.243+0200 W/W_INDICATOR( 1003): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
09-09 13:02:29.243+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
09-09 13:02:29.243+0200 W/W_HOME  ( 1088): event_manager.c: _apptray_visibility_cb(598) > apps,show,start
09-09 13:02:29.248+0200 W/W_HOME  ( 1088): event_manager.c: _apptray_visibility_cb(618) > state: 1 -> 0
09-09 13:02:29.248+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 13:02:29.248+0200 W/W_INDICATOR( 1003): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
09-09 13:02:29.248+0200 W/W_INDICATOR( 1003): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
09-09 13:02:29.248+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 13:02:29.253+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 13:02:29.253+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 13:02:29.253+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: onBubbleButtonEffect(2446) >  [249, 249, 249, 255]
09-09 13:02:29.268+0200 I/APP_CORE( 1088): appcore-efl.c: __do_app(529) > Legacy lifecycle: 1
09-09 13:02:29.268+0200 E/AUL     (  964): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
09-09 13:02:29.268+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 13:02:29.268+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 13:02:29.268+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 13:02:29.268+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 13:02:29.268+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-09 13:02:29.268+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 13:02:29.268+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
09-09 13:02:29.268+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 13:02:29.268+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 13:02:29.268+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 13:02:29.268+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 13:02:29.268+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-09 13:02:29.268+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
09-09 13:02:29.268+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 13:02:29.268+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
09-09 13:02:29.268+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-09 13:02:29.268+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-09 13:02:29.268+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 13:02:29.268+0200 W/MUSIC_CONTROL_SERVICE( 1500): music-control-service.c: _music_control_service_pasre_request(565) > [33m[TID:1500]   [com.samsung.w-home]register msg port [true][0m
09-09 13:02:29.278+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 14
09-09 13:02:29.288+0200 W/AUL_AMD (  509): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 1088
09-09 13:02:29.293+0200 W/MUSIC_CONTROL_SERVICE( 1500): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1500]   [MUSIC_PLAYER_EVENT][0m
09-09 13:02:29.293+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1500): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
09-09 13:02:29.293+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1500): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
09-09 13:02:29.293+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1500): preference.c: preference_get_int(1132) > preference_get_int(1500) : key(music-control-service_native/playing_diration) error
09-09 13:02:29.293+0200 W/MUSIC_CONTROL_SERVICE( 1500): music-control-info.c: music_control_info_get_player_position(626) > [31m[TID:1500]   preference_get_int() .. [0xfef00030][0m
09-09 13:02:29.293+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 13:02:29.293+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 13:02:29.293+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 13:02:29.293+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 13:02:29.293+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-09 13:02:29.293+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 13:02:29.293+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
09-09 13:02:29.293+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 13:02:29.298+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 13:02:29.298+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 13:02:29.298+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 13:02:29.298+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-09 13:02:29.298+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
09-09 13:02:29.298+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 13:02:29.298+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
09-09 13:02:29.298+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-09 13:02:29.298+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-09 13:02:29.298+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 13:02:29.298+0200 W/MUSIC_CONTROL_SERVICE( 1500): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1500]   [MUSIC_PLAYER_EVENT][0m
09-09 13:02:29.298+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1500): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
09-09 13:02:29.298+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1500): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
09-09 13:02:29.298+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1500): preference.c: preference_get_int(1132) > preference_get_int(1500) : key(music-control-service_native/playing_diration) error
09-09 13:02:29.298+0200 W/MUSIC_CONTROL_SERVICE( 1500): music-control-info.c: music_control_info_get_player_position(626) > [31m[TID:1500]   preference_get_int() .. [0xfef00030][0m
09-09 13:02:29.303+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 13:02:29.303+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 13:02:29.303+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 13:02:29.303+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 13:02:29.303+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-09 13:02:29.303+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 13:02:29.303+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
09-09 13:02:29.303+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 13:02:29.303+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 13:02:29.303+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 13:02:29.303+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 13:02:29.303+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-09 13:02:29.303+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
09-09 13:02:29.303+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 13:02:29.303+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
09-09 13:02:29.303+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-09 13:02:29.303+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-09 13:02:29.303+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 13:02:29.308+0200 I/TIZEN_N_SOUND_MANAGER( 1500): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000225
09-09 13:02:29.308+0200 E/TIZEN_N_SOUND_MANAGER( 1500): sound_manager_private.c: __convert_sound_manager_error_code(158) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000225)
09-09 13:02:29.308+0200 W/MUSIC_CONTROL_SERVICE( 1500): music-control-sound-manager.c: music_control_sound_mgr_get_volume(109) > [31m[TID:1500]   sound_manager_get_volume() .. [0xfe6a0001][0m
09-09 13:02:29.313+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 13:02:29.313+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 13:02:29.313+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 13:02:29.313+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 13:02:29.313+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-09 13:02:29.313+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 13:02:29.313+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
09-09 13:02:29.313+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 13:02:29.313+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 13:02:29.313+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 13:02:29.313+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 13:02:29.313+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-09 13:02:29.313+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
09-09 13:02:29.313+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 13:02:29.313+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
09-09 13:02:29.313+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-09 13:02:29.313+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-09 13:02:29.313+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 13:02:29.333+0200 W/W_HOME  ( 1088): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
09-09 13:02:29.333+0200 E/W_HOME  ( 1088): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
09-09 13:02:29.333+0200 W/W_HOME  ( 1088): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
09-09 13:02:29.333+0200 E/W_HOME  ( 1088): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
09-09 13:02:29.398+0200 I/CAPI_WATCH_APPLICATION( 1151): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-09 13:02:29.398+0200 E/watchface-loader( 1151): watchface-loader.cpp: OnAppTimeTick(812) > 
09-09 13:02:29.473+0200 I/watchface-viewer( 1151): viewer-part-resource-evas.cpp: ColonAnimationTimerExpired(2164) > 
09-09 13:02:29.543+0200 W/W_HOME  ( 1088): event_manager.c: _move_module_anim_end_cb(674) > state: 1 -> 0
09-09 13:02:29.543+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 13:02:29.548+0200 W/W_HOME  ( 1088): rotary.c: rotary_deattach(156) > rotary_deattach:0x4880b248
09-09 13:02:29.548+0200 I/efl-extension( 1088): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
09-09 13:02:29.548+0200 I/efl-extension( 1088): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4880b248, elm_layout, func : 0x40059565
09-09 13:02:29.548+0200 I/efl-extension( 1088): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
09-09 13:02:29.548+0200 I/efl-extension( 1088): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
09-09 13:02:29.548+0200 I/efl-extension( 1088): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
09-09 13:02:29.548+0200 I/efl-extension( 1088): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4607c708, elm_box, _activated_obj : 0x4880b248, activated : 1
09-09 13:02:29.548+0200 I/efl-extension( 1088): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
09-09 13:02:29.548+0200 W/W_HOME  ( 1088): event_manager.c: _apptray_visibility_cb(598) > apps,show
09-09 13:02:29.548+0200 W/W_HOME  ( 1088): event_manager.c: _apptray_visibility_cb(618) > state: 1 -> 1
09-09 13:02:29.548+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
09-09 13:02:29.548+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
09-09 13:02:29.548+0200 W/W_HOME  ( 1088): main.c: home_pause(550) > clock/widget paused
09-09 13:02:29.548+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
09-09 13:02:29.548+0200 W/APPS    ( 1088): apps_main.c: _time_changed_cb(409) >  date : 9->9
09-09 13:02:29.548+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
09-09 13:02:29.548+0200 W/W_HOME  ( 1088): rotary.c: rotary_attach(138) > rotary_attach:0x47c25398
09-09 13:02:29.548+0200 I/efl-extension( 1088): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x47c25398, elm_layout, _activated_obj : 0x4607c708, activated : 1
09-09 13:02:29.548+0200 I/efl-extension( 1088): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
09-09 13:02:29.548+0200 W/W_INDICATOR( 1003): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
09-09 13:02:29.548+0200 W/W_INDICATOR( 1003): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
09-09 13:02:29.548+0200 W/W_HOME  ( 1088): win.c: win_back_gesture_disable_set(170) > disable back gesture
09-09 13:02:29.548+0200 W/W_HOME  ( 1088): win.c: win_back_gesture_disable_set(170) > disable back gesture
09-09 13:02:29.548+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-09 13:02:29.548+0200 E/APPS    ( 1088): apps_main.c: apps_main_resume(1123) >  resumed already
09-09 13:02:29.568+0200 W/WATCH_CORE( 1151): appcore-watch.c: __widget_pause(1113) > widget_pause
09-09 13:02:29.568+0200 W/AUL     ( 1151): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(1151) status(bg) type(watchapp)
09-09 13:02:29.568+0200 E/watchface-loader( 1151): watchface-loader.cpp: OnAppPause(781) > 
09-09 13:02:29.568+0200 I/watchface-viewer( 1151): viewer-part-resource-evas.cpp: StopColonAnimation(2137) > 
09-09 13:02:30.043+0200 W/WATCH_CORE( 1151): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
09-09 13:02:30.043+0200 I/WATCH_CORE( 1151): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
09-09 13:02:30.043+0200 I/CAPI_WATCH_APPLICATION( 1151): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-09 13:02:30.043+0200 E/watchface-loader( 1151): watchface-loader.cpp: OnAppTimeTick(812) > 
09-09 13:02:30.043+0200 I/watchface-loader( 1151): watchface-loader.cpp: OnAppTimeTick(823) > set force update!!
09-09 13:02:30.043+0200 I/watchface-viewer( 1151): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(792) > ImagesLoadingDoneSignal().Emit()
09-09 13:02:30.043+0200 E/wnoti-service(  987): wnoti-db-utility.c: context_wearonoff_status_cb(1781) > status changed from 2 to 1 
09-09 13:02:30.043+0200 E/wnoti-service(  987): wnoti-native-client.c: handle_cache_notification(790) > >>
09-09 13:02:30.043+0200 W/WECONN  (  490): <__wc_feature_wearonoff_monitor_cb:532> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_ON
09-09 13:02:30.043+0200 W/WECONN  (  490): <__wc_device_on_wear_onoff_changed_cb:361> { state=WC_FEATURE_STATE_ON
09-09 13:02:30.048+0200 W/WECONN  (  490): <__wc_device_on_wear_onoff_changed_cb:376> Disconnected manually : 0
09-09 13:02:30.048+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23513) > wear_monitor_status update[0] = 2 -> 1
09-09 13:02:30.048+0200 W/WECONN  (  490): <__wc_device_on_wear_onoff_changed_cb:377> Disconnected by auto switch : 0
09-09 13:02:30.048+0200 W/WECONN  (  490): <__wc_device_on_wear_onoff_changed_cb:391> }
09-09 13:02:30.048+0200 W/WECONN  (  490): <__wc_feature_wearonoff_monitor_cb:552> }
09-09 13:02:30.103+0200 W/SHealthServiceCommon( 1374): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
09-09 13:02:30.208+0200 W/AUL_AMD (  509): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-09 13:02:30.208+0200 W/AUL_AMD (  509): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
09-09 13:02:30.288+0200 E/EFL     ( 1088): ecore_x<1088> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=6758422 button=1
09-09 13:02:30.288+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 13:02:30.288+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 13:02:30.288+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: touchPressed(1663) >  TOUCH [83, 169]
09-09 13:02:30.293+0200 E/W_HOME  ( 1088): util.c: util_is_rdu_retailmode(1530) > Cannot get the vconf for retailmode
09-09 13:02:30.308+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 13:02:30.323+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 13:02:30.333+0200 E/EFL     ( 1088): ecore_x<1088> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=6758465 button=1
09-09 13:02:30.333+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: touchReleased(1976) >  TOUCH [83, 169]->[92, 174]
09-09 13:02:30.333+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: runFocusAni(3491) >  nNewFocus[14], anim[1], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[15]
09-09 13:02:30.333+0200 W/APPS    ( 1088): AppsItem.cpp: onItemClicked(478) >  onItemClicked[0,14]
09-09 13:02:30.333+0200 E/APPS    ( 1088): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
09-09 13:02:30.333+0200 W/APPS    ( 1088): AppsItem.cpp: onItemClicked(502) >  item(watchapp) launched, open(0), tts(0)
09-09 13:02:30.333+0200 W/AUL     ( 1088): launch.c: app_request_to_launchpad(284) > request cmd(0) to(co.za.littlekidogo.watchapp)
09-09 13:02:30.338+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 0
09-09 13:02:30.338+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(1782) > caller pid : 1088
09-09 13:02:30.338+0200 I/AUL_AMD (  509): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
09-09 13:02:30.348+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(2218) > pad pid(-5)
09-09 13:02:30.353+0200 W/AUL_PAD ( 1235): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
09-09 13:02:30.353+0200 W/AUL_PAD ( 1235): launchpad.c: __send_result_to_caller(272) > Check app launching
09-09 13:02:30.353+0200 E/RESOURCED(  681): block.c: block_prelaunch_state(138) > insert data co.za.littlekidogo.watchapp, table num : 3
09-09 13:02:30.353+0200 W/AUL_PAD (14421): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
09-09 13:02:30.353+0200 W/AUL_PAD (14421): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
09-09 13:02:30.353+0200 W/AUL_PAD (14421): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
09-09 13:02:30.353+0200 W/AUL_PAD (14421): launchpad_loader.c: main(680) > [candidate] dlopen(co.za.littlekidogo.watchapp)
09-09 13:02:30.393+0200 I/efl-extension(14421): efl_extension.c: eext_mod_init(40) > Init
09-09 13:02:30.398+0200 I/UXT     (14421): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
09-09 13:02:30.398+0200 W/AUL_PAD (14421): launchpad_loader.c: main(690) > [candidate] dlsym
09-09 13:02:30.398+0200 W/AUL_PAD (14421): launchpad_loader.c: main(694) > [candidate] dl_main(co.za.littlekidogo.watchapp)
09-09 13:02:30.398+0200 I/CAPI_APPFW_APPLICATION(14421): app_main.c: ui_app_main(704) > app_efl_main
09-09 13:02:30.403+0200 I/CAPI_APPFW_APPLICATION(14421): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
09-09 13:02:30.453+0200 W/AUL     (  509): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(co.za.littlekidogo.watchapp) pid(14421) type(uiapp) bg(0)
09-09 13:02:30.453+0200 W/AUL_AMD (  509): amd_status.c: __socket_monitor_cb(1277) > (14421) was created
09-09 13:02:30.453+0200 E/AUL     (  509): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
09-09 13:02:30.453+0200 W/AUL     ( 1088): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14421)
09-09 13:02:30.453+0200 W/W_HOME  ( 1088): util.c: apps_util_launch_main_operation(785) > Launch app:[watchapp] ret:[0]
09-09 13:02:30.458+0200 W/W_HOME  ( 1088): util.c: send_launch_appId(620) > launch appid[co.za.littlekidogo.watchapp]
09-09 13:02:30.458+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 13:02:30.458+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 13:02:30.458+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 13:02:30.458+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 13:02:30.458+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-09 13:02:30.458+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 13:02:30.458+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.app-shortcut-widget:Apptray.Message.Launch.AppId]
09-09 13:02:30.458+0200 E/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
09-09 13:02:30.458+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 13:02:30.458+0200 E/MESSAGE_PORT( 1088): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (Apptray.Message.Launch.AppId) is not found.
09-09 13:02:30.458+0200 E/W_HOME  ( 1088): util.c: send_launch_appId(636) > There is no remote message port
09-09 13:02:30.463+0200 W/APPS    ( 1088): AppsItem.cpp: onItemClicked(536) >  appid(co.za.littlekidogo.watchapp)  pkgid(co.za.littlekidogo.watchapp), name(watchapp)
09-09 13:02:30.468+0200 W/STARTER (  964): pkg-monitor.c: _app_mgr_status_cb(400) > [_app_mgr_status_cb:400] Launch request [14421]
09-09 13:02:30.513+0200 E/EFL     (14421): ecore_evas<14421> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
09-09 13:02:30.578+0200 I/watchapp(14421): watchapp.c: create_base_gui(82) > adding Do GTD Review
09-09 13:02:30.578+0200 I/watchapp(14421): watchapp.c: create_base_gui(84) > tmp Task: D
09-09 13:02:30.578+0200 I/watchapp(14421): watchapp.c: create_base_gui(82) > adding Build Watch Prototype
09-09 13:02:30.578+0200 I/watchapp(14421): watchapp.c: create_base_gui(84) > tmp Task: B
09-09 13:02:30.578+0200 I/watchapp(14421): watchapp.c: create_base_gui(82) > adding Research African Markets
09-09 13:02:30.578+0200 I/watchapp(14421): watchapp.c: create_base_gui(84) > tmp Task: R
09-09 13:02:30.578+0200 I/watchapp(14421): watchapp.c: create_base_gui(82) > adding Go to Durbanville for Lunch
09-09 13:02:30.578+0200 I/watchapp(14421): watchapp.c: create_base_gui(84) > tmp Task: G
09-09 13:02:30.788+0200 W/CRASH_MANAGER(14604): worker.c: worker_job(1205) > 11144217761741536490950
09-09 13:02:30.928+0200 E/CAPI_MEDIA_CONTROLLER( 1134): media_controller_main.c: __mc_main_check_connection(34) > [0m[No-error] Timer is Called but there is working Process, connection_cnt = 3
09-09 13:02:31.508+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 14421 pgid = 14421
09-09 13:02:31.508+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
09-09 13:02:31.513+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __read_proc(55) > file open error : 2
09-09 13:02:31.513+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
09-09 13:02:31.513+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(14421), proc(0)
09-09 13:02:31.513+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
09-09 13:02:31.513+0200 E/AUL     ( 1272): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
09-09 13:02:31.513+0200 E/CAPI_APPFW_APP_MANAGER( 1272): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
09-09 13:02:31.598+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
09-09 13:02:31.603+0200 I/AUL_AMD (  509): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 14421
09-09 13:02:31.603+0200 W/AUL     (  509): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(14421)
09-09 13:02:31.648+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __read_proc(55) > file open error : 2
09-09 13:02:31.648+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
09-09 13:02:31.648+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(14421), proc(0)
09-09 13:02:31.648+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
09-09 13:02:31.648+0200 E/AUL     ( 1374): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
09-09 13:02:31.648+0200 E/CAPI_APPFW_APP_MANAGER( 1374): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
09-09 13:02:31.788+0200 I/AUL_PAD (14616): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
09-09 13:02:33.308+0200 W/W_INDICATOR( 1003): windicator_battery.c: windicator_battery_update(98) > [windicator_battery_update:98] 
09-09 13:02:33.308+0200 W/W_INDICATOR( 1003): windicator_battery.c: _battery_icon_update(313) > [_battery_icon_update:313] battery level(14), length(2)
09-09 13:02:33.308+0200 W/W_INDICATOR( 1003): windicator_battery.c: _battery_icon_update(337) > [_battery_icon_update:337] 14%
09-09 13:02:33.308+0200 W/W_INDICATOR( 1003): windicator_battery.c: _battery_icon_update(352) > [_battery_icon_update:352] battery_level: 14, isCharging: 0
09-09 13:02:33.308+0200 W/W_INDICATOR( 1003): windicator_battery.c: _battery_icon_update(386) > [_battery_icon_update:386] battery file : change_level_15
09-09 13:02:33.308+0200 W/W_INDICATOR( 1003): windicator_battery.c: _battery_icon_update(526) > [_battery_icon_update:526] Normal charging status !!
09-09 13:02:36.878+0200 E/EFL     ( 1088): ecore_x<1088> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=6765012 button=1
09-09 13:02:36.878+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 13:02:36.883+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 13:02:36.883+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: touchPressed(1663) >  TOUCH [135, 199]
09-09 13:02:36.883+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: onBubbleButtonEffect(2428) >  [249, 249, 249, 102]
09-09 13:02:36.883+0200 E/EFL     ( 1088): evas_main<1088> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
09-09 13:02:36.883+0200 E/EFL     ( 1088): evas_main<1088> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
09-09 13:02:36.883+0200 E/EFL     ( 1088): evas_main<1088> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
09-09 13:02:36.883+0200 E/W_HOME  ( 1088): util.c: util_is_rdu_retailmode(1530) > Cannot get the vconf for retailmode
09-09 13:02:36.898+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 13:02:36.898+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 13:02:36.908+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 13:02:36.923+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 13:02:36.933+0200 E/EFL     ( 1088): ecore_x<1088> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=6765065 button=1
09-09 13:02:36.933+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: touchReleased(1976) >  TOUCH [135, 199]->[126, 197]
09-09 13:02:36.933+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: onBubbleButtonEffect(2446) >  [249, 249, 249, 255]
09-09 13:02:36.933+0200 W/APPS    ( 1088): AppsItem.cpp: onItemClicked(478) >  onItemClicked[0,14]
09-09 13:02:36.933+0200 E/APPS    ( 1088): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
09-09 13:02:36.933+0200 W/APPS    ( 1088): AppsItem.cpp: onItemClicked(502) >  item(watchapp) launched, open(0), tts(0)
09-09 13:02:36.938+0200 W/AUL     ( 1088): launch.c: app_request_to_launchpad(284) > request cmd(0) to(co.za.littlekidogo.watchapp)
09-09 13:02:36.938+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 0
09-09 13:02:36.943+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(1782) > caller pid : 1088
09-09 13:02:36.943+0200 I/AUL_AMD (  509): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
09-09 13:02:36.953+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(2218) > pad pid(-5)
09-09 13:02:36.953+0200 W/AUL_PAD ( 1235): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
09-09 13:02:36.953+0200 W/AUL_PAD ( 1235): launchpad.c: __send_result_to_caller(272) > Check app launching
09-09 13:02:36.953+0200 W/AUL_PAD (14616): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
09-09 13:02:36.953+0200 W/AUL_PAD (14616): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
09-09 13:02:36.953+0200 W/AUL_PAD (14616): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
09-09 13:02:36.953+0200 W/AUL_PAD (14616): launchpad_loader.c: main(680) > [candidate] dlopen(co.za.littlekidogo.watchapp)
09-09 13:02:36.953+0200 E/RESOURCED(  681): block.c: block_prelaunch_state(138) > insert data co.za.littlekidogo.watchapp, table num : 3
09-09 13:02:37.003+0200 I/efl-extension(14616): efl_extension.c: eext_mod_init(40) > Init
09-09 13:02:37.008+0200 I/UXT     (14616): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
09-09 13:02:37.008+0200 W/AUL_PAD (14616): launchpad_loader.c: main(690) > [candidate] dlsym
09-09 13:02:37.008+0200 W/AUL_PAD (14616): launchpad_loader.c: main(694) > [candidate] dl_main(co.za.littlekidogo.watchapp)
09-09 13:02:37.008+0200 I/CAPI_APPFW_APPLICATION(14616): app_main.c: ui_app_main(704) > app_efl_main
09-09 13:02:37.018+0200 I/CAPI_APPFW_APPLICATION(14616): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
09-09 13:02:37.053+0200 W/AUL     (  509): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(co.za.littlekidogo.watchapp) pid(14616) type(uiapp) bg(0)
09-09 13:02:37.053+0200 W/AUL_AMD (  509): amd_status.c: __socket_monitor_cb(1277) > (14616) was created
09-09 13:02:37.053+0200 E/AUL     (  509): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
09-09 13:02:37.053+0200 W/AUL     ( 1088): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14616)
09-09 13:02:37.053+0200 W/W_HOME  ( 1088): util.c: apps_util_launch_main_operation(785) > Launch app:[watchapp] ret:[0]
09-09 13:02:37.058+0200 W/W_HOME  ( 1088): util.c: apps_util_launch_main_operation(792) > Suggest app:[co.za.littlekidogo.watchapp] 
09-09 13:02:37.058+0200 W/W_HOME  ( 1088): util.c: apps_util_suggestion_send_candidate(1692) > apps_util_suggestion_send_candidate pkgid:co.za.littlekidogo.watchapp
09-09 13:02:37.058+0200 E/W_HOME  ( 1088): page.c: suggestion_send_candidate(1176) > co.za.littlekidogo.watchapp suggestion_send_candidate
09-09 13:02:37.058+0200 E/APPS    ( 1088): db.c: suggestions_is_already_suggested(1334) >  suggestions_is_already_suggested pkgName:co.za.littlekidogo.watchapp 
09-09 13:02:37.058+0200 E/APPS    ( 1088): db.c: suggestions_db_bind_str(1236) >  index:[1]
09-09 13:02:37.058+0200 E/APPS    ( 1088): db.c: suggestions_db_bind_str(1237) >  str:[co.za.littlekidogo.watchapp]
09-09 13:02:37.058+0200 E/APPS    ( 1088): db.c: suggestions_db_bind_str(1238) >  strlen(str):[27]
09-09 13:02:37.058+0200 W/W_HOME  ( 1088): util.c: send_launch_appId(620) > launch appid[co.za.littlekidogo.watchapp]
09-09 13:02:37.058+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 13:02:37.058+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 13:02:37.058+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 13:02:37.058+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 13:02:37.058+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-09 13:02:37.058+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 13:02:37.058+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.app-shortcut-widget:Apptray.Message.Launch.AppId]
09-09 13:02:37.058+0200 E/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
09-09 13:02:37.063+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 13:02:37.063+0200 E/MESSAGE_PORT( 1088): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (Apptray.Message.Launch.AppId) is not found.
09-09 13:02:37.063+0200 E/W_HOME  ( 1088): util.c: send_launch_appId(636) > There is no remote message port
09-09 13:02:37.063+0200 W/APPS    ( 1088): AppsItem.cpp: onItemClicked(536) >  appid(co.za.littlekidogo.watchapp)  pkgid(co.za.littlekidogo.watchapp), name(watchapp)
09-09 13:02:37.068+0200 W/STARTER (  964): pkg-monitor.c: _app_mgr_status_cb(400) > [_app_mgr_status_cb:400] Launch request [14616]
09-09 13:02:37.183+0200 E/EFL     (14616): ecore_evas<14616> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
09-09 13:02:37.333+0200 I/watchapp(14616): watchapp.c: create_base_gui(82) > adding Do GTD Review
09-09 13:02:37.333+0200 I/watchapp(14616): watchapp.c: create_base_gui(84) > tmp Task: D
09-09 13:02:37.333+0200 I/watchapp(14616): watchapp.c: create_base_gui(82) > adding Build Watch Prototype
09-09 13:02:37.333+0200 I/watchapp(14616): watchapp.c: create_base_gui(84) > tmp Task: B
09-09 13:02:37.333+0200 I/watchapp(14616): watchapp.c: create_base_gui(82) > adding Research African Markets
09-09 13:02:37.333+0200 I/watchapp(14616): watchapp.c: create_base_gui(84) > tmp Task: R
09-09 13:02:37.333+0200 I/watchapp(14616): watchapp.c: create_base_gui(82) > adding Go to Durbanville for Lunch
09-09 13:02:37.333+0200 I/watchapp(14616): watchapp.c: create_base_gui(84) > tmp Task: G
09-09 13:02:37.458+0200 W/CRASH_MANAGER(14604): worker.c: worker_job(1205) > 1114616776174153649095
