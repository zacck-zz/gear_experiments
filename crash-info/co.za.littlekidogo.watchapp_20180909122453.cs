S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.7
Build-Number: R732XXU2FRC1
Build-Date: 2018.03.02 17:21:30

Crash Information
Process Name: watchapp
PID: 8458
Date: 2018-09-09 12:24:53+0200
Executable File Path: /opt/usr/apps/co.za.littlekidogo.watchapp/bin/watchapp
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x4

Register Information
r0   = 0x00000004, r1   = 0x00000004
r2   = 0x00000000, r3   = 0xffffffff
r4   = 0x00000000, r5   = 0xbe8bfdd0
r6   = 0x414c06f1, r7   = 0x00000004
r8   = 0x0000002d, r9   = 0x00000000
r10  = 0x414c06d8, fp   = 0xbe8bfdc4
ip   = 0xbe8c0314, sp   = 0xbe8bf858
lr   = 0x404bee8c, pc   = 0x404f40b4
cpsr = 0x60000010

Memory Information
MemTotal:   490112 KB
MemFree:     20560 KB
Buffers:     32260 KB
Cached:     151912 KB
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
be8a0000 be8c1000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8458)
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
er_status pid(964) type(wakeup)
09-09 12:24:06.025+0200 E/RESOURCED(  681): freezer-process.c: freezer_process_pid_set(150) > Cant find process info for 964
09-09 12:24:06.030+0200 E/ALARM_MANAGER(  964): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.astarter] : Alarm id [1567130967]
09-09 12:24:06.030+0200 W/STARTER (  964): clock-mgr.c: __starter_clock_mgr_homescreen_alarm_cb(968) > [__starter_clock_mgr_homescreen_alarm_cb:968] homescreen alarm timer expired [1567130967]
09-09 12:24:06.035+0200 W/AUL     (  964): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-home)
09-09 12:24:06.040+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 0
09-09 12:24:06.045+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(1782) > caller pid : 964
09-09 12:24:06.050+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __alarm_expired(1447) > alarm_id[1567130967] is expired.
09-09 12:24:06.050+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __save_module_log(1780) > The file is not ready.
09-09 12:24:06.050+0200 E/ALARM_MANAGER(  524): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1567130967, next duetime: 1536488666
09-09 12:24:06.050+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-09 12:24:06.050+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 9-9-2018, 10:24:26 (UTC).
09-09 12:24:06.050+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-09 12:24:06.050+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __save_module_log(1780) > The file is not ready.
09-09 12:24:06.050+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __alarm_handler_idle(1512) > Unlock the display from LCD OFF
09-09 12:24:06.055+0200 W/AUL     (  509): app_signal.c: aul_send_app_resume_request_signal(567) > aul_send_app_resume_request_signal app(com.samsung.w-home) pid(1088) type(uiapp) bg(0)
09-09 12:24:06.055+0200 W/AUL_AMD (  509): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 1088
09-09 12:24:06.055+0200 I/APP_CORE( 1088): appcore-efl.c: __do_app(453) > [APP 1088] Event: RESET State: PAUSED
09-09 12:24:06.055+0200 I/CAPI_APPFW_APPLICATION( 1088): app_main.c: app_appcore_reset(245) > app_appcore_reset
09-09 12:24:06.055+0200 W/CAPI_APPFW_APP_CONTROL( 1088): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
09-09 12:24:06.055+0200 W/AUL_AMD (  509): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(1088), cmd(0)
09-09 12:24:06.055+0200 E/W_HOME  ( 1088): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
09-09 12:24:06.055+0200 W/W_HOME  ( 1088): main.c: _app_control_progress(1606) > Service value : show_clock
09-09 12:24:06.055+0200 W/W_HOME  ( 1088): main.c: _app_control_progress(1623) > Show clock operation
09-09 12:24:06.060+0200 W/AUL     (  964): launch.c: app_request_to_launchpad(298) > request cmd(0) result(1088)
09-09 12:24:06.060+0200 E/W_HOME  ( 1088): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
09-09 12:24:06.060+0200 W/W_HOME  ( 1088): gesture.c: _clock_show(242) > clock show
09-09 12:24:06.065+0200 W/W_HOME  ( 1088): gesture.c: _clock_show(257) > home raise
09-09 12:24:06.070+0200 E/W_HOME  ( 1088): gesture.c: gesture_win_aux_set(402) > wm.policy.win.do.not.use.deiconify.approve:-1
09-09 12:24:06.070+0200 W/W_HOME  ( 1088): dbus_util.c: home_dbus_home_raise_signal_send(298) > Sending HOME RAISE signal, result:0
09-09 12:24:06.070+0200 W/W_HOME  ( 1088): gesture.c: _clock_show(260) > home raise done
09-09 12:24:06.070+0200 W/W_HOME  ( 1088): gesture.c: _clock_show(267) > show clock
09-09 12:24:06.070+0200 W/W_HOME  ( 1088): index.c: index_hide(338) > hide VI:0 visibility:0 vi:(nil)
09-09 12:24:06.070+0200 W/W_HOME  ( 1088): move.c: move_back_to_home_no_anim(325) > back to home no anim
09-09 12:24:06.070+0200 W/W_HOME  ( 1088): rotary.c: rotary_attach(138) > rotary_attach:0x4880b248
09-09 12:24:06.075+0200 I/efl-extension( 1088): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4880b248, elm_layout, _activated_obj : 0x4607c708, activated : 1
09-09 12:24:06.075+0200 I/efl-extension( 1088): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
09-09 12:24:06.075+0200 W/W_HOME  ( 1088): event_manager.c: _move_module_anim_start_cb(660) > state: 0 -> 1
09-09 12:24:06.075+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:3, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
09-09 12:24:06.075+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
09-09 12:24:06.085+0200 W/W_HOME  ( 1088): event_manager.c: _move_module_anim_end_cb(674) > state: 1 -> 0
09-09 12:24:06.085+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:3, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:24:06.085+0200 W/W_HOME  ( 1088): rotary.c: rotary_deattach(156) > rotary_deattach:0x4880b248
09-09 12:24:06.085+0200 I/efl-extension( 1088): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
09-09 12:24:06.085+0200 I/efl-extension( 1088): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4880b248, elm_layout, func : 0x40059565
09-09 12:24:06.085+0200 I/efl-extension( 1088): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
09-09 12:24:06.085+0200 I/efl-extension( 1088): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
09-09 12:24:06.085+0200 I/efl-extension( 1088): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
09-09 12:24:06.085+0200 I/efl-extension( 1088): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4607c708, elm_box, _activated_obj : 0x4880b248, activated : 1
09-09 12:24:06.085+0200 I/efl-extension( 1088): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
09-09 12:24:06.085+0200 W/W_HOME  ( 1088): gesture.c: _manual_render(182) > 
09-09 12:24:06.085+0200 W/W_INDICATOR( 1003): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
09-09 12:24:06.085+0200 W/W_INDICATOR( 1003): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
09-09 12:24:06.090+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
09-09 12:24:06.095+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [964].
09-09 12:24:06.095+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(1567130967)
09-09 12:24:06.100+0200 W/W_INDICATOR( 1003): windicator_moment_bar.c: windicator_moment_bar_hide_directly(548) > [windicator_moment_bar_hide_directly:548] windicator_moment_bar_hide_directly
09-09 12:24:06.110+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
09-09 12:24:06.110+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-09 12:24:06.110+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 9-9-2018, 10:35:07 (UTC).
09-09 12:24:06.110+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-09 12:24:06.110+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __save_module_log(1780) > The file is not ready.
09-09 12:24:06.130+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
09-09 12:24:06.130+0200 E/ALARM_MANAGER(  524): alarm-manager.c: alarm_manager_alarm_delete(2462) > alarm_id[1567130967] is removed.
09-09 12:24:06.130+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __save_module_log(1780) > The file is not ready.
09-09 12:24:06.135+0200 W/STARTER (  964): pkg-monitor.c: _app_mgr_status_cb(421) > [_app_mgr_status_cb:421] Resume request [1088]
09-09 12:24:06.260+0200 I/APP_CORE( 1088): appcore-efl.c: __do_app(529) > Legacy lifecycle: 1
09-09 12:24:06.260+0200 W/W_HOME  ( 1088): event_manager.c: _apptray_visibility_cb(598) > apps,hide,start
09-09 12:24:06.260+0200 W/W_HOME  ( 1088): event_manager.c: _apptray_visibility_cb(618) > state: 1 -> 0
09-09 12:24:06.260+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:24:06.265+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:24:06.265+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:24:06.265+0200 W/W_INDICATOR( 1003): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
09-09 12:24:06.265+0200 W/W_INDICATOR( 1003): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
09-09 12:24:06.265+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:5, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:24:06.265+0200 W/W_HOME  ( 1088): event_manager.c: _apptray_visibility_cb(598) > apps,hide
09-09 12:24:06.265+0200 W/W_HOME  ( 1088): event_manager.c: _apptray_visibility_cb(618) > state: 1 -> 0
09-09 12:24:06.265+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:24:06.270+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:24:06.270+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:24:06.270+0200 W/W_INDICATOR( 1003): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
09-09 12:24:06.270+0200 W/W_INDICATOR( 1003): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
09-09 12:24:06.270+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:5, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:24:06.280+0200 E/APPS    ( 1088): apps_main.c: apps_main_pause(1085) >  paused already
09-09 12:24:07.055+0200 W/AUL_AMD (  509): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-09 12:24:07.055+0200 W/AUL_AMD (  509): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
09-09 12:24:24.485+0200 E/CAPI_MEDIA_CONTROLLER( 1134): media_controller_main.c: __mc_main_check_connection(34) > [0m[No-error] Timer is Called but there is working Process, connection_cnt = 3
09-09 12:24:44.775+0200 E/PKGMGR  ( 8426): pkgmgr.c: __pkgmgr_client_uninstall(2061) > uninstall pkg start.
09-09 12:24:44.955+0200 E/PKGMGR_SERVER( 8428): pkgmgr-server.c: main(2242) > package manager server start
09-09 12:24:45.075+0200 E/PKGMGR_SERVER( 8428): pm-mdm.c: _pm_check_mdm_policy(1078) > [0;31m[_pm_check_mdm_policy(): 1078](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
09-09 12:24:45.075+0200 E/PKGMGR  ( 8426): pkgmgr.c: __pkgmgr_client_uninstall(2186) > uninstall pkg finish, ret=[84260002]
09-09 12:24:45.080+0200 E/PKGMGR_SERVER( 8429): pkgmgr-server.c: queue_job(1962) > UNINSTALL start, pkgid=[co.za.littlekidogo.watchapp]
09-09 12:24:45.170+0200 E/rpm-installer( 8429): rpm-appcore-intf.c: main(120) > ------------------------------------------------
09-09 12:24:45.170+0200 E/rpm-installer( 8429): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
09-09 12:24:45.170+0200 E/rpm-installer( 8429): rpm-appcore-intf.c: main(122) > ------------------------------------------------
09-09 12:24:45.285+0200 E/rpm-installer( 8429): rpm-cmdline.c: __ri_is_core_tpk_app(358) > This is a core tpk app.
09-09 12:24:45.405+0200 W/W_HOME  ( 1088): clock_event.c: _pkgmgr_event_cb(194) > Pkg:co.za.littlekidogo.watchapp is being uninstalled
09-09 12:24:45.405+0200 W/W_HOME  ( 1088): dbox.c: uninstall_cb(1434) > uninstalled:co.za.littlekidogo.watchapp
09-09 12:24:45.415+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 14
09-09 12:24:45.430+0200 W/AUL_AMD (  509): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
09-09 12:24:45.430+0200 W/AUL_AMD (  509): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(co.za.littlekidogo.watchapp), key(start), value(uninstall)
09-09 12:24:45.430+0200 W/AUL_AMD (  509): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(997) > __amd_pkgmgrinfo_start_handler
09-09 12:24:45.445+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_cb_log_package(4750) > package [_________] callback : [UNINSTALL, STARTED]
09-09 12:24:45.460+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
09-09 12:24:45.465+0200 E/PKGMGR_PARSER( 8429): pkgmgr_parser_signature.c: __ps_check_mdm_policy_by_pkgid(1056) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
09-09 12:24:45.465+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-09 12:24:45.465+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 9-9-2018, 10:35:07 (UTC).
09-09 12:24:45.465+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-09 12:24:45.465+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __save_module_log(1780) > The file is not ready.
09-09 12:24:45.490+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
09-09 12:24:45.630+0200 E/PKGMGR_CERT( 8429): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(616) > Transaction Begin
09-09 12:24:45.635+0200 E/PKGMGR_CERT( 8429): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(621) > Certificate Deletion Success
09-09 12:24:45.650+0200 E/PKGMGR_CERT( 8429): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(634) > Transaction Commit and End
09-09 12:24:45.650+0200 E/rpm-installer( 8429): coretpk-installer.c: _coretpk_installer_uninstall_package(4163) > success
09-09 12:24:45.650+0200 E/rpm-installer( 8429): coretpk-installer.c: _coretpk_installer_uninstall_package(4164) > try to classify and delete residual files
09-09 12:24:45.665+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 8255 pgid = 8255
09-09 12:24:45.665+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
09-09 12:24:45.750+0200 I/AUL_AMD (  509): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 8255
09-09 12:24:45.750+0200 W/AUL     (  509): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(8255)
09-09 12:24:45.780+0200 E/STORAGE_CLEANER( 8429): storage-cleaner.c: __create_handle(448) > Failed to prepare stmt
09-09 12:24:45.820+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
09-09 12:24:45.820+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 8187 pgid = -1
09-09 12:24:45.820+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
09-09 12:24:45.820+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
09-09 12:24:45.830+0200 I/AUL_AMD (  509): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 8187
09-09 12:24:45.835+0200 W/AUL     (  509): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(8187)
09-09 12:24:46.045+0200 I/AUL_AMD (  509): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 8188
09-09 12:24:46.045+0200 W/AUL     (  509): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(8188)
09-09 12:24:47.225+0200 I/AUL_PAD ( 8432): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
09-09 12:24:47.375+0200 I/efl-extension( 8433): efl_extension.c: eext_mod_init(40) > Init
09-09 12:24:47.390+0200 W/MM_CAMCORDER( 8434): mm_camcorder_internal.c: _mmcamcorder_constructor(203) >  start
09-09 12:24:47.395+0200 W/MM_CAMCORDER( 8434): mm_camcorder_internal.c: _mmcamcorder_constructor(213) >  done
09-09 12:24:47.405+0200 I/efl-extension( 8434): efl_extension.c: eext_mod_init(40) > Init
09-09 12:24:47.485+0200 E/PKGMGR_SERVER( 8428): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
09-09 12:24:47.595+0200 W/W_HOME  ( 1088): clock_event.c: _pkgmgr_event_cb(226) > Pkg:co.za.littlekidogo.watchapp is uninstalled, delete related resource
09-09 12:24:47.595+0200 W/W_HOME  ( 1088): clock_event.c: _pkgmgr_event_cb(230) > attacheck clock:com.samsung.watchface
09-09 12:24:47.595+0200 W/W_HOME  ( 1088): dbox.c: uninstall_cb(1434) > uninstalled:co.za.littlekidogo.watchapp
09-09 12:24:47.605+0200 E/PUSHD   ( 1171): db.c: _get_app_info_by_query(316) > DB step: 101 [unknown error]
09-09 12:24:47.605+0200 E/PUSHD   ( 1171): db.c: db_reg_get_by_tizen_pkg_id(393) > Fail to get app_info
09-09 12:24:47.620+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: onRemoveItem(466) >  [watchapp]
09-09 12:24:47.620+0200 W/APPS    ( 1088): AppsItem.cpp: setLastIndex(1280) >  This is last index app [13:Galaxy Apps], focusIdx[14]
09-09 12:24:47.620+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
09-09 12:24:47.620+0200 W/APPS    ( 1088): AppsItem.cpp: onItemBadgeRemove(864) >  [watchapp] remove badge db
09-09 12:24:47.630+0200 W/AUL_AMD (  509): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(co.za.littlekidogo.watchapp), key(end), value(ok)
09-09 12:24:47.630+0200 W/AUL_AMD (  509): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1037) > g_hash_table_foreach_remove, 1
09-09 12:24:47.635+0200 E/STARTER (  964): pkg-monitor.c: _pkg_monitor_get_mainappid(105) > [_pkg_monitor_get_mainappid:105] Failed to get pkginfo[-1]
09-09 12:24:47.650+0200 E/rpm-installer( 8429): rpm-appcore-intf.c: main(273) > ------------------------------------------------
09-09 12:24:47.650+0200 E/rpm-installer( 8429): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
09-09 12:24:47.650+0200 E/rpm-installer( 8429): rpm-appcore-intf.c: main(275) > ------------------------------------------------
09-09 12:24:47.660+0200 E/PKGMGR_SERVER( 8428): pkgmgr-server.c: sighandler(486) > child NORMAL exit [8429]
09-09 12:24:47.665+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_cb_log_package(4750) > package [_________] callback : [UNINSTALL, COMPLETED]
09-09 12:24:47.665+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7029) > package uninstall complete
09-09 12:24:47.665+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7035) > disabled_pkg_list : 
09-09 12:24:47.665+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_package_uninstall_event(4929) > 
09-09 12:24:47.665+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(2046) > Found in install_req_list?[0], index[-1]
09-09 12:24:47.665+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_package_uninstall_event(4935) > installe_req_list is NULL.
09-09 12:24:47.685+0200 E/WMS     (  526): wms_db.c: wms_db_package_event_insert_record(190) > 
09-09 12:24:47.690+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
09-09 12:24:47.690+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-09 12:24:47.690+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 9-9-2018, 10:35:07 (UTC).
09-09 12:24:47.690+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-09 12:24:47.690+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __save_module_log(1780) > The file is not ready.
09-09 12:24:47.725+0200 E/EFL     ( 1088): elementary<1088> elm_layout.c:1021 _elm_layout_smart_content_set() could not swallow 0x487e3230 into part 'elm.swallow.event.0'
09-09 12:24:47.735+0200 W/APPS    ( 1088): AppsItem.cpp: setLastIndex(1280) >  This is last index app [13:Galaxy Apps], focusIdx[13]
09-09 12:24:47.735+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
09-09 12:24:47.740+0200 W/APPS    ( 1088): AppsItem.cpp: aniFocusIndex(2373) >  [Galaxy Apps:13] Focused[0], focusIdx[13]
09-09 12:24:47.740+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
09-09 12:24:47.740+0200 W/APPS    ( 1088): db.c: apps_db_read_list(621) >  
09-09 12:24:47.805+0200 E/RESOURCED(  681): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/8429/oom_score_adj failed
09-09 12:24:47.805+0200 E/RESOURCED(  681): proc-main.c: resourced_proc_status_change(1501) > Empty pid or process not exists. 8429
09-09 12:24:47.825+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
09-09 12:24:47.955+0200 I/UXT     ( 8433): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
09-09 12:24:47.970+0200 E/PKGMGR  ( 8444): pkgmgr.c: pkgmgr_client_install(1651) > install pkg start.
09-09 12:24:48.030+0200 E/PKGMGR  ( 8428): pkgmgr-internal.c: _get_type_from_zip(771) > /opt/usr/apps/tmp/co.za.littlekidogo.watchapp-1.0.0-arm.tpk is core
09-09 12:24:48.030+0200 E/PKGMGR  ( 8428): pkgmgr-internal.c: _get_type_from_zip(771) > /opt/usr/apps/tmp/co.za.littlekidogo.watchapp-1.0.0-arm.tpk is core
09-09 12:24:48.035+0200 E/rpm-installer( 8428): installer-util.c: _installer_util_delete_dir(420) > (dp == NULL) opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
09-09 12:24:48.035+0200 E/BACKEND_LIB( 8428): librpm.c: __is_symlink_file(70) > file is safe
09-09 12:24:48.045+0200 E/PKGMGR_SERVER( 8428): pm-mdm.c: _pm_get_signature_info_from_file(1364) > open : fd == -1, err=[1118711444]
09-09 12:24:48.055+0200 E/PKGMGR_SERVER( 8428): pm-mdm.c: _pm_check_mdm_policy(1078) > [0;31m[_pm_check_mdm_policy(): 1078](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
09-09 12:24:48.060+0200 E/PKGMGR  ( 8444): pkgmgr.c: pkgmgr_client_install(1768) > install pkg finish, ret=[84440002]
09-09 12:24:48.065+0200 E/PKGMGR_SERVER( 8446): pkgmgr-server.c: queue_job(2138) > COMM_REQ_OBSERVER start, pkgid=[]
09-09 12:24:48.100+0200 E/PKGMGR_SERVER( 8447): pkgmgr-server.c: queue_job(1944) > INSTALL start, pkg path=[/opt/usr/apps/tmp/co.za.littlekidogo.watchapp-1.0.0-arm.tpk]
09-09 12:24:48.180+0200 E/PKGMGR_OBSERVER( 8446): pkg_observer.c: main(601) > OBSERVER start
09-09 12:24:48.205+0200 E/rpm-installer( 8447): rpm-appcore-intf.c: main(120) > ------------------------------------------------
09-09 12:24:48.205+0200 E/rpm-installer( 8447): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
09-09 12:24:48.205+0200 E/rpm-installer( 8447): rpm-appcore-intf.c: main(122) > ------------------------------------------------
09-09 12:24:48.320+0200 E/rpm-installer( 8447): rpm-appcore-intf.c: main(207) > [/opt/usr/apps/tmp/co.za.littlekidogo.watchapp-1.0.0-arm.tpk] is tpk package.
09-09 12:24:48.330+0200 E/rpm-installer( 8447): coretpk-parser.c: __coretpk_parser_get_value(1713) > (result_value == NULL) [install-location] is empty.
09-09 12:24:48.330+0200 E/rpm-installer( 8447): coretpk-parser.c: __coretpk_parser_get_value_list(1670) > (ret == 1) [//*[name() ='privileges']/*[name()='privilege']] is empty.
09-09 12:24:48.330+0200 E/rpm-installer( 8447): coretpk-parser.c: _coretpk_parser_is_widget(1586) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget'])
09-09 12:24:48.335+0200 E/rpm-installer( 8447): coretpk-parser.c: _coretpk_parser_is_custom_clock(1480) > (ret == 1) metadata(watchface) is empty.
09-09 12:24:48.335+0200 E/rpm-installer( 8447): installer-util.c: _installer_util_delete_dir(420) > (dp == NULL) opendir(/opt/usr/data/pkgmgr/co.za.littlekidogo.watchapp/) failed. [2][No such file or directory]
09-09 12:24:48.335+0200 E/rpm-installer( 8447): coretpk-installer.c: _coretpk_installer_install_package(3579) > Deletion failed: [/opt/usr/data/pkgmgr/co.za.littlekidogo.watchapp/]
09-09 12:24:48.380+0200 I/AUL_PAD ( 8433): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
09-09 12:24:48.435+0200 E/MALI    ( 8433): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
09-09 12:24:48.435+0200 E/MALI    ( 8433): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
09-09 12:24:48.435+0200 E/MALI    ( 8433): [gpu-ddk] devel/graphics_drv/r4p0
09-09 12:24:48.435+0200 E/MALI    ( 8433): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
09-09 12:24:48.435+0200 E/MALI    ( 8433): [coregl] devel/graphics_engine/master
09-09 12:24:48.435+0200 E/MALI    ( 8433): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
09-09 12:24:48.445+0200 E/PKGMGR_OBSERVER( 8446): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[84460002] pkg_type[tpk] pkgid[co.za.littlekidogo.watchapp] key[start] val[install]
09-09 12:24:48.460+0200 W/AUL_AMD (  509): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(co.za.littlekidogo.watchapp), key(start), value(install)
09-09 12:24:48.465+0200 E/PKGMGR_OBSERVER( 8446): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[84460002] pkg_type[tpk] pkgid[co.za.littlekidogo.watchapp] key[install_percent] val[30]
09-09 12:24:48.485+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_cb_log_package(4750) > package [_________] callback : [INSTALL, STARTED]
09-09 12:24:48.520+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_cb_log_package(4750) > package [_________] callback : [INSTALL, PROCESSING]
09-09 12:24:48.665+0200 W/CERT_SVC( 8447): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
09-09 12:24:48.685+0200 E/rpm-installer( 8447): coretpk-parser.c: __coretpk_parser_verify_metadata(48) > (ret == 1) metadata is empty.
09-09 12:24:48.685+0200 E/rpm-installer( 8447): coretpk-parser.c: __coretpk_parser_append_path(417) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
09-09 12:24:48.685+0200 E/rpm-installer( 8447): coretpk-parser.c: __coretpk_parser_append_path(417) > (ret == 1) NodeSet is empty. (//*[name()='widget-application']//*[name()='support-size']/@preview)
09-09 12:24:48.685+0200 E/rpm-installer( 8447): coretpk-parser.c: __coretpk_parser_widget_replace_widget_tag(541) > (ret == 1) NodeSet is empty. (//*[name() = 'widget-application'])
09-09 12:24:48.740+0200 E/PKGMGR_PARSER( 8447): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2167) > Manifest is Valid
09-09 12:24:48.740+0200 E/PKGMGR_PARSER( 8447): pkgmgr_parser.c: __parse_manifest_for_installation(1910) > parsing manifest for installation: /opt/share/packages/co.za.littlekidogo.watchapp.xml
09-09 12:24:48.745+0200 E/PKGMGR_PARSER( 8447): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
09-09 12:24:48.745+0200 E/PKGMGR_PARSER( 8447): pkgmgr_parser.c: __ps_process_tag(866) > tag is NULL
09-09 12:24:48.920+0200 I/efl-extension( 8447): efl_extension.c: eext_mod_init(40) > Init
09-09 12:24:48.920+0200 I/efl-extension( 8447): efl_extension.c: eext_mod_shutdown(46) > Shutdown
09-09 12:24:49.000+0200 E/PKGMGR_PARSER( 8447): pkgmgr_parser.c: __parse_manifest_for_installation(1952) > parsing manifest for installation Done
09-09 12:24:49.030+0200 E/PKGMGR_CERT( 8447): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
09-09 12:24:49.035+0200 E/PKGMGR_CERT( 8447): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 106
09-09 12:24:49.035+0200 E/PKGMGR_CERT( 8447): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 106
09-09 12:24:49.035+0200 E/PKGMGR_CERT( 8447): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 18 1
09-09 12:24:49.035+0200 E/PKGMGR_CERT( 8447): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 19 1
09-09 12:24:49.035+0200 E/PKGMGR_CERT( 8447): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 20 1
09-09 12:24:49.035+0200 E/PKGMGR_CERT( 8447): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 21 1
09-09 12:24:49.055+0200 E/PKGMGR_CERT( 8447): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(575) > Transaction Commit and End
09-09 12:24:49.060+0200 E/PKGMGR_OBSERVER( 8446): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[84460002] pkg_type[tpk] pkgid[co.za.littlekidogo.watchapp] key[install_percent] val[60]
09-09 12:24:49.075+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_cb_log_package(4750) > package [_________] callback : [INSTALL, PROCESSING]
09-09 12:24:49.145+0200 E/rpm-installer( 8447): installer-util.c: _installer_util_get_configuration_value(601) > [signature]=[on]
09-09 12:24:49.155+0200 E/rpm-installer( 8447): coretpk-installer.c: _coretpk_installer_apply_smack(3199) > groupid = [w6l2VmL6T64TYV9CBa3rojTUP5k2M5pEdQ7YlS8k4wc=] for shared/trusted.
09-09 12:24:49.160+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 8432 pgid = 8432
09-09 12:24:49.160+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
09-09 12:24:49.190+0200 I/AUL_AMD (  509): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 8434
09-09 12:24:49.190+0200 W/AUL     (  509): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(8434)
09-09 12:24:49.210+0200 E/rpm-installer( 8447): coretpk-installer.c: __post_install_for_mmc(742) > (handle == NULL) handle is NULL.
09-09 12:24:49.250+0200 E/PKGMGR_OBSERVER( 8446): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[84460002] pkg_type[tpk] pkgid[co.za.littlekidogo.watchapp] key[install_percent] val[100]
09-09 12:24:49.275+0200 E/rpm-installer( 8447): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
09-09 12:24:49.290+0200 I/AUL_AMD (  509): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 8432
09-09 12:24:49.295+0200 W/AUL     (  509): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(8432)
09-09 12:24:49.320+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_cb_log_package(4750) > package [_________] callback : [INSTALL, PROCESSING]
09-09 12:24:49.365+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
09-09 12:24:49.365+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 8433 pgid = -1
09-09 12:24:49.365+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
09-09 12:24:49.365+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
09-09 12:24:49.375+0200 I/AUL_AMD (  509): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 8433
09-09 12:24:49.375+0200 W/AUL     (  509): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(8433)
09-09 12:24:49.485+0200 E/PKGMGR_SERVER( 8428): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
09-09 12:24:49.765+0200 I/efl-extension( 8459): efl_extension.c: eext_mod_init(40) > Init
09-09 12:24:49.840+0200 I/UXT     ( 8459): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
09-09 12:24:49.945+0200 I/AUL_PAD ( 8459): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
09-09 12:24:49.970+0200 E/MALI    ( 8459): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
09-09 12:24:49.970+0200 E/MALI    ( 8459): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
09-09 12:24:49.970+0200 E/MALI    ( 8459): [gpu-ddk] devel/graphics_drv/r4p0
09-09 12:24:49.970+0200 E/MALI    ( 8459): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
09-09 12:24:49.970+0200 E/MALI    ( 8459): [coregl] devel/graphics_engine/master
09-09 12:24:49.970+0200 E/MALI    ( 8459): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
09-09 12:24:49.970+0200 E/MALI    ( 8459): 
09-09 12:24:50.840+0200 I/AUL_PAD ( 8458): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
09-09 12:24:51.135+0200 E/PKGMGR_OBSERVER( 8446): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[84460002] pkg_type[tpk] pkgid[co.za.littlekidogo.watchapp] key[end] val[ok]
09-09 12:24:51.200+0200 E/PKGMGR_INFO( 8446): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(1026) > callback is stopped.
09-09 12:24:51.205+0200 W/AUL_AMD (  509): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(co.za.littlekidogo.watchapp), key(end), value(ok)
09-09 12:24:51.220+0200 E/PKGMGR_OBSERVER( 8446): pkg_observer.c: main(620) > OBSERVER end
09-09 12:24:51.230+0200 E/PKGMGR_SERVER( 8428): pkgmgr-server.c: sighandler(486) > child NORMAL exit [8446]
09-09 12:24:51.280+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_cb_log_package(4750) > package [_________] callback : [INSTALL, COMPLETED]
09-09 12:24:51.280+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7086) > package install complete
09-09 12:24:51.280+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_package_install_event(5040) > 
09-09 12:24:51.280+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(2046) > Found in install_req_list?[0], index[-1]
09-09 12:24:51.280+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_package_install_event(5066) > triggered from Gear itself.
09-09 12:24:51.325+0200 E/STARTER (  964): pkg-monitor.c: _pkg_monitor_get_metadata(136) > [_pkg_monitor_get_metadata:136] Failed to get metadata value[-2]
09-09 12:24:51.325+0200 E/PKGMGR_INFO(  525): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(922) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
09-09 12:24:51.335+0200 E/WMS     (  526): wms_db.c: wms_db_package_event_insert_record(190) > 
09-09 12:24:51.350+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2892) > send_install_response completed : END
09-09 12:24:51.375+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: onAddItem(356) >  [watchapp]
09-09 12:24:51.430+0200 W/APPS    ( 1088): AppsBadge.cpp: onBadgeInit(124) >  [watchapp] Badge is not exist
09-09 12:24:51.430+0200 W/APPS    ( 1088): AppsItem.cpp: setLastIndex(1273) >  This is not last index app [13:Galaxy Apps]
09-09 12:24:51.430+0200 E/Vi::Animations( 1088): result Vi::Animations::_AnimationManager::addAnimation(Vi::Animations::Visual&, const string*, Vi::Animations::Animation&)(288) > [E_OBJ_ALREADY_EXIST] Animation with keyName already exists. key name = hide
09-09 12:24:51.430+0200 I/Vi::Animations( 1088): result Vi::Animations::_VisualImpl::addAnimation(const string*, Vi::Animations::Animation&)(6999) > [E_OBJ_ALREADY_EXIST] Propagating.
09-09 12:24:51.435+0200 W/APPS    ( 1088): AppsItem.cpp: setLastIndex(1280) >  This is last index app [14:watchapp], focusIdx[13]
09-09 12:24:51.435+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
09-09 12:24:51.440+0200 E/EFL     ( 1088): elementary<1088> elm_layout.c:1021 _elm_layout_smart_content_set() could not swallow 0x487e3230 into part 'elm.swallow.event.0'
09-09 12:24:51.440+0200 W/APPS    ( 1088): AppsItem.cpp: aniFocusIndex(2373) >  [Galaxy Apps:13] Focused[1], focusIdx[13]
09-09 12:24:51.445+0200 W/APPS    ( 1088): AppsItem.cpp: setLastIndex(1280) >  This is last index app [14:watchapp], focusIdx[13]
09-09 12:24:51.445+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
09-09 12:24:51.445+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
09-09 12:24:51.445+0200 W/APPS    ( 1088): db.c: apps_db_read_list(621) >  
09-09 12:24:51.485+0200 E/PKGMGR_SERVER( 8428): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
09-09 12:24:51.775+0200 W/MM_CAMCORDER( 8460): mm_camcorder_internal.c: _mmcamcorder_constructor(203) >  start
09-09 12:24:51.775+0200 W/MM_CAMCORDER( 8460): mm_camcorder_internal.c: _mmcamcorder_constructor(213) >  done
09-09 12:24:51.785+0200 I/efl-extension( 8460): efl_extension.c: eext_mod_init(40) > Init
09-09 12:24:52.685+0200 I/AUL     ( 8460): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 12:24:52.700+0200 I/AUL     ( 8460): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 12:24:52.700+0200 E/AUL     ( 8460): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
09-09 12:24:52.700+0200 E/AUL     ( 8460): aul_path.c: __get_path(169) > root_path is NULL!
09-09 12:24:52.715+0200 I/AUL     ( 8460): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 12:24:52.725+0200 I/AUL     ( 8460): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 12:24:52.725+0200 E/AUL     ( 8460): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
09-09 12:24:52.725+0200 E/AUL     ( 8460): aul_path.c: __get_path(169) > root_path is NULL!
09-09 12:24:52.740+0200 I/AUL     ( 8460): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 12:24:52.755+0200 I/AUL     ( 8460): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 12:24:52.755+0200 E/AUL     ( 8460): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
09-09 12:24:52.755+0200 E/AUL     ( 8460): aul_path.c: __get_path(169) > root_path is NULL!
09-09 12:24:52.770+0200 I/AUL     ( 8460): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 12:24:52.790+0200 I/AUL     ( 8460): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 12:24:52.790+0200 E/AUL     ( 8460): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
09-09 12:24:52.790+0200 E/AUL     ( 8460): aul_path.c: __get_path(169) > root_path is NULL!
09-09 12:24:52.825+0200 I/AUL     ( 8460): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 12:24:52.835+0200 I/AUL     ( 8460): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 12:24:52.835+0200 E/AUL     ( 8460): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
09-09 12:24:52.835+0200 E/AUL     ( 8460): aul_path.c: __get_path(169) > root_path is NULL!
09-09 12:24:52.855+0200 I/AUL     ( 8460): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 12:24:53.005+0200 I/AUL     ( 8460): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 12:24:53.005+0200 E/AUL     ( 8460): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
09-09 12:24:53.010+0200 E/AUL     ( 8460): aul_path.c: __get_path(169) > root_path is NULL!
09-09 12:24:53.050+0200 I/AUL     ( 8460): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 12:24:53.065+0200 E/rpm-installer( 8447): rpm-appcore-intf.c: main(273) > ------------------------------------------------
09-09 12:24:53.065+0200 E/rpm-installer( 8447): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
09-09 12:24:53.065+0200 E/rpm-installer( 8447): rpm-appcore-intf.c: main(275) > ------------------------------------------------
09-09 12:24:53.075+0200 E/PKGMGR_SERVER( 8428): pkgmgr-server.c: sighandler(486) > child NORMAL exit [8447]
09-09 12:24:53.080+0200 I/AUL     ( 8460): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 12:24:53.080+0200 E/AUL     ( 8460): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
09-09 12:24:53.080+0200 E/AUL     ( 8460): aul_path.c: __get_path(169) > root_path is NULL!
09-09 12:24:53.100+0200 I/AUL     ( 8460): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 12:24:53.115+0200 I/AUL     ( 8460): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 12:24:53.115+0200 E/AUL     ( 8460): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
09-09 12:24:53.115+0200 E/AUL     ( 8460): aul_path.c: __get_path(169) > root_path is NULL!
09-09 12:24:53.150+0200 I/UXT     ( 8460): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
09-09 12:24:53.150+0200 E/RESOURCED(  681): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/8447/oom_score_adj failed
09-09 12:24:53.150+0200 E/RESOURCED(  681): proc-main.c: resourced_proc_status_change(1501) > Empty pid or process not exists. 8447
09-09 12:24:53.330+0200 E/MALI    ( 8460): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
09-09 12:24:53.330+0200 E/MALI    ( 8460): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
09-09 12:24:53.330+0200 E/MALI    ( 8460): [gpu-ddk] devel/graphics_drv/r4p0
09-09 12:24:53.330+0200 E/MALI    ( 8460): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
09-09 12:24:53.330+0200 E/MALI    ( 8460): [coregl] devel/graphics_engine/master
09-09 12:24:53.330+0200 E/MALI    ( 8460): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
09-09 12:24:53.330+0200 E/MALI    ( 8460): 
09-09 12:24:53.345+0200 W/AUL     ( 8484): launch.c: app_request_to_launchpad(284) > request cmd(0) to(co.za.littlekidogo.watchapp)
09-09 12:24:53.350+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 0
09-09 12:24:53.365+0200 I/AUL_AMD (  509): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
09-09 12:24:53.375+0200 I/AUL_AMD (  509): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
09-09 12:24:53.375+0200 E/AUL_AMD (  509): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
09-09 12:24:53.375+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(1782) > caller pid : 8484
09-09 12:24:53.390+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(2218) > pad pid(-5)
09-09 12:24:53.390+0200 W/AUL_PAD ( 1235): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
09-09 12:24:53.390+0200 W/AUL_PAD ( 1235): launchpad.c: __send_result_to_caller(272) > Check app launching
09-09 12:24:53.390+0200 E/RESOURCED(  681): block.c: block_prelaunch_state(138) > insert data co.za.littlekidogo.watchapp, table num : 3
09-09 12:24:53.395+0200 W/AUL_PAD ( 8458): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
09-09 12:24:53.395+0200 W/AUL_PAD ( 8458): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
09-09 12:24:53.395+0200 W/AUL_PAD ( 8458): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
09-09 12:24:53.395+0200 W/AUL_PAD ( 8458): launchpad_loader.c: main(680) > [candidate] dlopen(co.za.littlekidogo.watchapp)
09-09 12:24:53.450+0200 I/efl-extension( 8458): efl_extension.c: eext_mod_init(40) > Init
09-09 12:24:53.455+0200 I/UXT     ( 8458): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
09-09 12:24:53.455+0200 W/AUL_PAD ( 8458): launchpad_loader.c: main(690) > [candidate] dlsym
09-09 12:24:53.455+0200 W/AUL_PAD ( 8458): launchpad_loader.c: main(694) > [candidate] dl_main(co.za.littlekidogo.watchapp)
09-09 12:24:53.460+0200 I/CAPI_APPFW_APPLICATION( 8458): app_main.c: ui_app_main(704) > app_efl_main
09-09 12:24:53.470+0200 I/CAPI_APPFW_APPLICATION( 8458): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
09-09 12:24:53.485+0200 E/PKGMGR_SERVER( 8428): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
09-09 12:24:53.485+0200 E/PKGMGR_SERVER( 8428): pkgmgr-server.c: main(2296) > package manager server terminated.
09-09 12:24:53.495+0200 W/AUL     (  509): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(co.za.littlekidogo.watchapp) pid(8458) type(uiapp) bg(0)
09-09 12:24:53.495+0200 W/AUL     ( 8484): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8458)
09-09 12:24:53.495+0200 W/AUL_AMD (  509): amd_status.c: __socket_monitor_cb(1277) > (8458) was created
09-09 12:24:53.520+0200 W/STARTER (  964): pkg-monitor.c: _app_mgr_status_cb(400) > [_app_mgr_status_cb:400] Launch request [8458]
09-09 12:24:53.610+0200 E/EFL     ( 8458): ecore_evas<8458> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
09-09 12:24:53.690+0200 I/watchapp( 8458): watchapp.c: create_base_gui(82) > list items Do GTD Review
09-09 12:24:53.690+0200 I/watchapp( 8458): watchapp.c: create_base_gui(82) > list items Build Watch Prototype
09-09 12:24:53.695+0200 I/watchapp( 8458): watchapp.c: create_base_gui(82) > list items Research African Markets
09-09 12:24:53.695+0200 I/watchapp( 8458): watchapp.c: create_base_gui(82) > list items Go to Durbanville for Lunch
09-09 12:24:53.910+0200 W/CRASH_MANAGER( 8485): worker.c: worker_job(1205) > 1108458776174153648869
