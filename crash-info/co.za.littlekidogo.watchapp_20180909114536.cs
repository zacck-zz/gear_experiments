S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.7
Build-Number: R732XXU2FRC1
Build-Date: 2018.03.02 17:21:30

Crash Information
Process Name: watchapp
PID: 4220
Date: 2018-09-09 11:45:36+0200
Executable File Path: /opt/usr/apps/co.za.littlekidogo.watchapp/bin/watchapp
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x2

Register Information
r0   = 0x00000002, r1   = 0x00000025
r2   = 0xbefde2bc, r3   = 0x00000002
r4   = 0xfbad8001, r5   = 0xbefde1a0
r6   = 0xbefde2bc, r7   = 0x4040b000
r8   = 0x00000000, r9   = 0x0000107c
r10  = 0x00000002, fp   = 0xbefde194
ip   = 0x4040a9c8, sp   = 0xbefddc18
lr   = 0x4031af50, pc   = 0x40357928
cpsr = 0x20000010

Memory Information
MemTotal:   490112 KB
MemFree:     21204 KB
Buffers:     25964 KB
Cached:     161536 KB
VmPeak:      82480 KB
VmSize:      82412 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15968 KB
VmRSS:       15968 KB
VmData:      21848 KB
VmStk:         136 KB
VmExe:           8 KB
VmLib:       24612 KB
VmPTE:          50 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 4220 TID = 4220
4220 4225 4226 

Maps Information
40000000 40002000 r-xp /opt/usr/apps/co.za.littlekidogo.watchapp/bin/watchapp
40004000 40008000 r-xp /usr/lib/libsys-assert.so
40012000 4002f000 r-xp /lib/ld-2.13.so
40039000 40044000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
4004e000 40052000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4005a000 40062000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
40063000 40065000 r-xp /usr/lib/libdlog.so.0.0.0
4006d000 4008e000 r-xp /usr/lib/libefl-extension.so.0.1.0
40096000 401d2000 r-xp /usr/lib/libelementary.so.1.7.99
401e9000 402b7000 r-xp /usr/lib/libevas.so.1.7.99
402dd000 40401000 r-xp /lib/libc-2.13.so
4040f000 40417000 r-xp /lib/libgcc_s-4.6.so.1
40418000 40423000 r-xp /lib/libunwind.so.8.0.1
40450000 40452000 r-xp /lib/libdl-2.13.so
4045b000 4045f000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
40468000 4046a000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
40473000 40479000 r-xp /usr/lib/libappcore-efl.so.1.1
40481000 40486000 r-xp /usr/lib/libappcore-common.so.1.1
4048e000 4049b000 r-xp /usr/lib/libaul.so.0.1.0
404a5000 404c8000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
404d0000 40511000 r-xp /usr/lib/libeina.so.1.7.99
4051a000 4052e000 r-xp /lib/libpthread-2.13.so
40539000 40589000 r-xp /usr/lib/libecore_x.so.1.7.99
4058b000 405ad000 r-xp /usr/lib/libecore_evas.so.1.7.99
405b6000 405bf000 r-xp /usr/lib/libvconf.so.0.2.45
405c7000 405ef000 r-xp /usr/lib/libfontconfig.so.1.8.0
405f0000 406bc000 r-xp /usr/lib/libxml2.so.2.7.8
406c9000 40799000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
4079a000 407ac000 r-xp /usr/lib/libefl-assist.so.0.1.0
407b4000 4081d000 r-xp /lib/libm-2.13.so
40826000 4083d000 r-xp /usr/lib/libecore.so.1.7.99
40854000 408b2000 r-xp /usr/lib/libedje.so.1.7.99
408bc000 40974000 r-xp /usr/lib/libcairo.so.2.11200.14
4097f000 40a60000 r-xp /usr/lib/libX11.so.6.3.0
40a6b000 40a74000 r-xp /usr/lib/libXi.so.6.1.0
40a7c000 40a95000 r-xp /usr/lib/libeet.so.1.7.99
40aa6000 40aab000 r-xp /usr/lib/libecore_file.so.1.7.99
40ab3000 40ac4000 r-xp /usr/lib/libecore_input.so.1.7.99
40acc000 40ad5000 r-xp /usr/lib/libedbus.so.1.7.99
40add000 40b07000 r-xp /usr/lib/libdbus-1.so.3.8.12
40b10000 40b2a000 r-xp /usr/lib/libecore_con.so.1.7.99
40b33000 40b46000 r-xp /usr/lib/libfribidi.so.0.3.1
40b4e000 40b93000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
40b9c000 40bf2000 r-xp /usr/lib/libfreetype.so.6.11.3
40bfe000 40c54000 r-xp /usr/lib/libpixman-1.so.0.28.2
40c61000 40c67000 r-xp /usr/lib/libappsvc.so.0.1.0
40c6f000 40c72000 r-xp /usr/lib/libbundle.so.0.1.22
40c7a000 40c80000 r-xp /usr/lib/libecore_imf.so.1.7.99
40c88000 40cbc000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40cc5000 40cc7000 r-xp /usr/lib/libiniparser.so.0
40cd0000 40ce7000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
40cf0000 40cf5000 r-xp /usr/lib/libxdgmime.so.1.1.0
40cfd000 40cfe000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
40d06000 40d24000 r-xp /usr/lib/libsystemd.so.0.4.0
40d2e000 40d48000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40d50000 40dc5000 r-xp /usr/lib/libsqlite3.so.0.8.6
40dd0000 40dd6000 r-xp /lib/librt-2.13.so
40ddf000 40de6000 r-xp /usr/lib/libXcursor.so.1.0.2
40dee000 40df0000 r-xp /usr/lib/libXdamage.so.1.1.0
40df8000 40dfa000 r-xp /usr/lib/libXcomposite.so.1.0.0
40e02000 40e04000 r-xp /usr/lib/libXgesture.so.7.0.0
40e0d000 40e10000 r-xp /usr/lib/libXfixes.so.3.1.0
40e18000 40e19000 r-xp /usr/lib/libXinerama.so.1.0.0
40e22000 40e28000 r-xp /usr/lib/libXrandr.so.2.2.0
40e30000 40e36000 r-xp /usr/lib/libXrender.so.1.3.0
40e3e000 40e42000 r-xp /usr/lib/libXtst.so.6.1.0
40e4a000 40e54000 r-xp /usr/lib/libXext.so.6.4.0
40e5e000 40e63000 r-xp /usr/lib/libecore_fb.so.1.7.99
40e6c000 40e70000 r-xp /usr/lib/libecore_ipc.so.1.7.99
40e79000 40e7c000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
40e84000 40e9a000 r-xp /lib/libexpat.so.1.6.0
40ea4000 40eba000 r-xp /lib/libz.so.1.2.5
40ec3000 40ed9000 r-xp /usr/lib/libtts.so
40ee2000 40f05000 r-xp /usr/lib/libui-extension.so.0.1.0
40f0e000 40f19000 r-xp /usr/lib/libtbm.so.1.0.0
40f21000 40f28000 r-xp /usr/lib/libembryo.so.1.7.99
40f30000 40f47000 r-xp /usr/lib/liblua-5.1.so
40f51000 40f52000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
40f5a000 40f68000 r-xp /usr/lib/libGLESv2.so.2.0
40f71000 40f89000 r-xp /usr/lib/libpng12.so.0.50.0
40f91000 40f92000 r-xp /usr/lib/libxcb-shm.so.0.0.0
40f9b000 40fa1000 r-xp /usr/lib/libxcb-render.so.0.0.0
40faa000 40fbd000 r-xp /usr/lib/libxcb.so.1.1.0
40fc6000 40fc9000 r-xp /usr/lib/libEGL.so.1.4
40fd1000 40ff4000 r-xp /usr/lib/libjpeg.so.8.0.2
4100c000 41050000 r-xp /usr/lib/libcurl.so.4.3.0
4105a000 41060000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
41069000 4106a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
41072000 41077000 r-xp /usr/lib/libffi.so.5.0.10
4107f000 41152000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
4115d000 4115f000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
41168000 41180000 r-xp /usr/lib/liblzma.so.5.0.3
41188000 41198000 r-xp /lib/libresolv-2.13.so
4119c000 4119e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
411a7000 411a9000 r-xp /usr/lib/journal/libjournal.so.0.1.0
411b2000 411b7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
411bf000 411ee000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
411f6000 411f9000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41201000 41202000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
4120b000 41393000 r-xp /usr/lib/libicui18n.so.57.1
413a4000 414aa000 r-xp /usr/lib/libicuuc.so.57.1
414c0000 41554000 r-xp /usr/lib/libstdc++.so.6.0.16
41567000 4156f000 r-xp /usr/lib/libdrm.so.2.4.0
41577000 41579000 r-xp /usr/lib/libdri2.so.0.0.0
41581000 41583000 r-xp /usr/lib/libXau.so.6.0.0
4158c000 41595000 r-xp /usr/lib/libcares.so.2.1.0
4159e000 415cc000 r-xp /usr/lib/libidn.so.11.5.44
415d4000 4161b000 r-xp /usr/lib/libssl.so.1.0.0
41627000 417b9000 r-xp /usr/lib/libcrypto.so.1.0.0
417da000 417dc000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
417e5000 417e9000 r-xp /usr/lib/libsmack.so.1.0.0
417f2000 4180f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
41818000 4181e000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41826000 4182b000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41833000 4184c000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
430ee000 430f0000 r-xp /usr/lib/libiri.so
430f8000 430fb000 r-xp /lib/libcap.so.2.21
43103000 4310a000 r-xp /lib/libcrypt-2.13.so
4313a000 4315b000 r-xp /usr/lib/libexif.so.12.3.3
4316f000 43171000 r-xp /usr/lib/libttrace.so.1.1
43179000 4317e000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43186000 4318c000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43195000 4319d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
431a5000 431a8000 r-xp /lib/libattr.so.1.1.0
431b1000 431d3000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
431dc000 431e3000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
431ec000 431ee000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
431f6000 431fd000 r-xp /usr/lib/libminizip.so.1.0.0
43205000 43212000 r-xp /usr/lib/libail.so.0.1.0
4321c000 43222000 r-xp /usr/lib/libproc-stat.so.0.2.96
4322a000 4322b000 r-xp /usr/lib/libresponse.so.0.2.96
43233000 43238000 r-xp /usr/lib/libsystem.so.0.0.0
43348000 43412000 r-xp /usr/lib/libCOREGL.so.4.0
43424000 43448000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
43451000 43520000 r-xp /usr/lib/libscim-1.0.so.8.2.3
43536000 43540000 r-xp /lib/libnss_files-2.13.so
43868000 438dd000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
438ed000 43a36000 r-xp /usr/lib/egl/libMali.so
43a43000 43a48000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43a59000 43a5c000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43a65000 44264000 rw-p [stack:4225]
44265000 44a64000 rw-p [stack:4226]
44d18000 44d2f000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44edf000 44ee0000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
befbe000 befdf000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4220)
Call Stack Count: 1
 0: strchrnul + 0x14 (0x40357928) [/lib/libc.so.6] + 0x7a928
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
(5178) >  elm_cache_all_flush
09-09 11:45:05.445+0200 W/MUSIC_CONTROL_SERVICE( 1500): music-control-service.c: _music_control_service_pasre_request(565) > [33m[TID:1500]   [com.samsung.w-home]register msg port [false][0m
09-09 11:45:05.475+0200 E/ALARM_MANAGER(  524): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 621605897, next duetime: 1536486325
09-09 11:45:05.475+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(621605897)
09-09 11:45:05.475+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1536487199), due_time(1536486325)
09-09 11:45:05.485+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
09-09 11:45:05.490+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-09 11:45:05.490+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 9-9-2018, 09:45:25 (UTC).
09-09 11:45:05.490+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-09 11:45:05.490+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __save_module_log(1780) > The file is not ready.
09-09 11:45:05.495+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
09-09 11:45:05.495+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __save_module_log(1780) > The file is not ready.
09-09 11:45:05.935+0200 I/APP_CORE( 1088): appcore-efl.c: __do_app(453) > [APP 1088] Event: MEM_FLUSH State: PAUSED
09-09 11:45:10.445+0200 I/APP_CORE( 1088): appcore-efl.c: __do_app(453) > [APP 1088] Event: MEM_FLUSH State: PAUSED
09-09 11:45:15.165+0200 E/CAPI_SYSTEM_INFO( 1743): system_info_parse.c: system_info_get_value_from_config_xml(279) > cannot find tizen.org/feature/container field from /etc/config/model-config.xml file!!!
09-09 11:45:15.165+0200 E/CAPI_SYSTEM_INFO( 1743): system_info.c: system_info_get_platform_bool(293) > cannot get tizen.org/feature/container
09-09 11:45:24.545+0200 E/CAPI_MEDIA_CONTROLLER( 1134): media_controller_main.c: __mc_main_check_connection(34) > [0m[No-error] Timer is Called but there is working Process, connection_cnt = 3
09-09 11:45:24.995+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __alarm_handler_idle(1486) > Lock the display not to enter LCD OFF
09-09 11:45:25.010+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
09-09 11:45:25.025+0200 W/AUL     (  524): app_signal.c: aul_update_freezer_status(456) > aul_update_freezer_status pid(964) type(wakeup)
09-09 11:45:25.030+0200 E/RESOURCED(  681): freezer-process.c: freezer_process_pid_set(150) > Cant find process info for 964
09-09 11:45:25.035+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __alarm_expired(1447) > alarm_id[621605897] is expired.
09-09 11:45:25.035+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __save_module_log(1780) > The file is not ready.
09-09 11:45:25.035+0200 E/ALARM_MANAGER(  524): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 621605897, next duetime: 1536486345
09-09 11:45:25.035+0200 E/ALARM_MANAGER(  964): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.astarter] : Alarm id [621605897]
09-09 11:45:25.035+0200 W/STARTER (  964): clock-mgr.c: __starter_clock_mgr_homescreen_alarm_cb(968) > [__starter_clock_mgr_homescreen_alarm_cb:968] homescreen alarm timer expired [621605897]
09-09 11:45:25.035+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-09 11:45:25.035+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 9-9-2018, 09:45:45 (UTC).
09-09 11:45:25.040+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-09 11:45:25.040+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __save_module_log(1780) > The file is not ready.
09-09 11:45:25.040+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __alarm_handler_idle(1512) > Unlock the display from LCD OFF
09-09 11:45:25.045+0200 W/AUL     (  964): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-home)
09-09 11:45:25.045+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 0
09-09 11:45:25.050+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(1782) > caller pid : 964
09-09 11:45:25.060+0200 W/AUL     (  509): app_signal.c: aul_send_app_resume_request_signal(567) > aul_send_app_resume_request_signal app(com.samsung.w-home) pid(1088) type(uiapp) bg(0)
09-09 11:45:25.060+0200 W/AUL_AMD (  509): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 1088
09-09 11:45:25.060+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
09-09 11:45:25.065+0200 I/APP_CORE( 1088): appcore-efl.c: __do_app(453) > [APP 1088] Event: RESET State: PAUSED
09-09 11:45:25.065+0200 I/CAPI_APPFW_APPLICATION( 1088): app_main.c: app_appcore_reset(245) > app_appcore_reset
09-09 11:45:25.065+0200 W/CAPI_APPFW_APP_CONTROL( 1088): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
09-09 11:45:25.065+0200 E/W_HOME  ( 1088): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
09-09 11:45:25.065+0200 W/W_HOME  ( 1088): main.c: _app_control_progress(1606) > Service value : show_clock
09-09 11:45:25.065+0200 W/W_HOME  ( 1088): main.c: _app_control_progress(1623) > Show clock operation
09-09 11:45:25.065+0200 E/W_HOME  ( 1088): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
09-09 11:45:25.065+0200 W/W_HOME  ( 1088): gesture.c: _clock_show(242) > clock show
09-09 11:45:25.070+0200 W/AUL_AMD (  509): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(1088), cmd(0)
09-09 11:45:25.070+0200 W/AUL     (  964): launch.c: app_request_to_launchpad(298) > request cmd(0) result(1088)
09-09 11:45:25.075+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [964].
09-09 11:45:25.075+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(621605897)
09-09 11:45:25.080+0200 W/W_HOME  ( 1088): gesture.c: _clock_show(257) > home raise
09-09 11:45:25.080+0200 E/W_HOME  ( 1088): gesture.c: gesture_win_aux_set(402) > wm.policy.win.do.not.use.deiconify.approve:-1
09-09 11:45:25.085+0200 W/W_HOME  ( 1088): dbus_util.c: home_dbus_home_raise_signal_send(298) > Sending HOME RAISE signal, result:0
09-09 11:45:25.085+0200 W/W_HOME  ( 1088): gesture.c: _clock_show(260) > home raise done
09-09 11:45:25.085+0200 W/W_HOME  ( 1088): gesture.c: _clock_show(267) > show clock
09-09 11:45:25.085+0200 W/W_HOME  ( 1088): index.c: index_hide(338) > hide VI:0 visibility:0 vi:(nil)
09-09 11:45:25.085+0200 W/W_HOME  ( 1088): move.c: move_back_to_home_no_anim(325) > back to home no anim
09-09 11:45:25.085+0200 W/W_HOME  ( 1088): rotary.c: rotary_attach(138) > rotary_attach:0x4880b248
09-09 11:45:25.090+0200 I/efl-extension( 1088): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4880b248, elm_layout, _activated_obj : 0x4607c708, activated : 1
09-09 11:45:25.090+0200 I/efl-extension( 1088): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
09-09 11:45:25.090+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
09-09 11:45:25.090+0200 W/W_HOME  ( 1088): event_manager.c: _move_module_anim_start_cb(660) > state: 0 -> 1
09-09 11:45:25.090+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-09 11:45:25.090+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 9-9-2018, 09:59:59 (UTC).
09-09 11:45:25.090+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-09 11:45:25.090+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __save_module_log(1780) > The file is not ready.
09-09 11:45:25.090+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:3, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
09-09 11:45:25.090+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
09-09 11:45:25.095+0200 W/W_INDICATOR( 1003): windicator_moment_bar.c: windicator_moment_bar_hide_directly(548) > [windicator_moment_bar_hide_directly:548] windicator_moment_bar_hide_directly
09-09 11:45:25.095+0200 W/W_INDICATOR( 1003): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
09-09 11:45:25.095+0200 W/W_INDICATOR( 1003): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
09-09 11:45:25.095+0200 W/W_HOME  ( 1088): event_manager.c: _move_module_anim_end_cb(674) > state: 1 -> 0
09-09 11:45:25.095+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:3, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 11:45:25.095+0200 W/W_HOME  ( 1088): rotary.c: rotary_deattach(156) > rotary_deattach:0x4880b248
09-09 11:45:25.095+0200 I/efl-extension( 1088): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
09-09 11:45:25.095+0200 I/efl-extension( 1088): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4880b248, elm_layout, func : 0x40059565
09-09 11:45:25.095+0200 I/efl-extension( 1088): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
09-09 11:45:25.095+0200 I/efl-extension( 1088): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
09-09 11:45:25.095+0200 I/efl-extension( 1088): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
09-09 11:45:25.095+0200 I/efl-extension( 1088): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4607c708, elm_box, _activated_obj : 0x4880b248, activated : 1
09-09 11:45:25.095+0200 I/efl-extension( 1088): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
09-09 11:45:25.095+0200 W/W_HOME  ( 1088): gesture.c: _manual_render(182) > 
09-09 11:45:25.105+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
09-09 11:45:25.105+0200 E/ALARM_MANAGER(  524): alarm-manager.c: alarm_manager_alarm_delete(2462) > alarm_id[621605897] is removed.
09-09 11:45:25.105+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __save_module_log(1780) > The file is not ready.
09-09 11:45:25.110+0200 W/STARTER (  964): pkg-monitor.c: _app_mgr_status_cb(421) > [_app_mgr_status_cb:421] Resume request [1088]
09-09 11:45:25.250+0200 I/APP_CORE( 1088): appcore-efl.c: __do_app(529) > Legacy lifecycle: 1
09-09 11:45:25.250+0200 W/W_HOME  ( 1088): event_manager.c: _apptray_visibility_cb(598) > apps,hide,start
09-09 11:45:25.250+0200 W/W_HOME  ( 1088): event_manager.c: _apptray_visibility_cb(618) > state: 1 -> 0
09-09 11:45:25.250+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 11:45:25.250+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 11:45:25.250+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 11:45:25.250+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:5, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 11:45:25.255+0200 W/W_HOME  ( 1088): event_manager.c: _apptray_visibility_cb(598) > apps,hide
09-09 11:45:25.255+0200 W/W_HOME  ( 1088): event_manager.c: _apptray_visibility_cb(618) > state: 1 -> 0
09-09 11:45:25.255+0200 W/W_INDICATOR( 1003): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
09-09 11:45:25.255+0200 W/W_INDICATOR( 1003): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
09-09 11:45:25.255+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 11:45:25.255+0200 W/W_INDICATOR( 1003): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
09-09 11:45:25.255+0200 W/W_INDICATOR( 1003): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
09-09 11:45:25.260+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 11:45:25.260+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 11:45:25.260+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:5, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 11:45:25.265+0200 E/APPS    ( 1088): apps_main.c: apps_main_pause(1085) >  paused already
09-09 11:45:25.575+0200 W/SHealthCommon( 1374): CpuLock.cpp: CheckAndReset(178) > [1;40;33mRELEASE POWER LOCK CPU[0;m
09-09 11:45:25.695+0200 W/SHealthCommon( 1374): TimelineSessionStorage.cpp: OnTriggered(1290) > [1;40;33mlocalStartTime: 1536451200000.000000[0;m
09-09 11:45:25.745+0200 W/WSLibCore( 1374): JsonMessage.cpp: Parse(113) > [1;40;33mparsing is failed (activity_type:-1,estimated_active_time:90232.589053,estimated_calorie:5.430000,exercise_duration_time:0.000000,exercise_uuid:,is_auto_exercise:0,sleep_efficiency:0.000000,subtractive_active_time:0.000000,subtractive_calorie:0.000000)[0;m
09-09 11:45:25.745+0200 W/WSLibCore( 1374): JsonSerializeManipulator.cpp: DeserializeThrowException(226) > [1;40;33mIt's not json serialized string[0;m
09-09 11:45:25.750+0200 W/WSLibCore( 1374): JsonMessage.cpp: Parse(113) > [1;40;33mparsing is failed (activity_type:-1,estimated_active_time:15845.513834,estimated_calorie:2.290000,exercise_duration_time:0.000000,exercise_uuid:,is_auto_exercise:0,sleep_efficiency:0.000000,subtractive_active_time:0.000000,subtractive_calorie:0.000000)[0;m
09-09 11:45:25.750+0200 W/WSLibCore( 1374): JsonSerializeManipulator.cpp: DeserializeThrowException(226) > [1;40;33mIt's not json serialized string[0;m
09-09 11:45:25.750+0200 W/WSLibCore( 1374): JsonMessage.cpp: Parse(113) > [1;40;33mparsing is failed (activity_type:-1,estimated_active_time:0.000000,estimated_calorie:0.000000,exercise_duration_time:0.000000,exercise_uuid:,is_auto_exercise:0,sleep_efficiency:0.000000,subtractive_active_time:0.000000,subtractive_calorie:0.000000)[0;m
09-09 11:45:25.750+0200 W/WSLibCore( 1374): JsonSerializeManipulator.cpp: DeserializeThrowException(226) > [1;40;33mIt's not json serialized string[0;m
09-09 11:45:25.795+0200 W/SHealthCommon( 1374): SHealthMessagePortConnection.cpp: SendServiceMessage(558) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 1[0;m
09-09 11:45:25.800+0200 W/SHealthCommon( 1374): SHealthMessagePortConnection.cpp: SendServiceMessage(558) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
09-09 11:45:25.800+0200 W/SHealthServiceCommon( 1374): EnergyExpenditureFeatureController.cpp: OnTotalEnergyExpenditureChanged(119) > [1;40;33mstart 1536444000000.000000, end 1536486325805.000000, calories 804.669731[0;m
09-09 11:45:25.800+0200 W/SHealthCommon( 1374): SHealthMessagePortConnection.cpp: SendServiceMessage(558) > [1;40;33mmessageName: energy_expenditure_updated, pendingClientInfoList.size(): 0[0;m
09-09 11:45:26.065+0200 W/AUL_AMD (  509): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-09 11:45:26.065+0200 W/AUL_AMD (  509): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
09-09 11:45:26.645+0200 E/PKGMGR  ( 4175): pkgmgr.c: __pkgmgr_client_uninstall(2061) > uninstall pkg start.
09-09 11:45:26.815+0200 E/PKGMGR_SERVER( 4177): pkgmgr-server.c: main(2242) > package manager server start
09-09 11:45:26.920+0200 E/PKGMGR_SERVER( 4177): pm-mdm.c: _pm_check_mdm_policy(1078) > [0;31m[_pm_check_mdm_policy(): 1078](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
09-09 11:45:26.925+0200 E/PKGMGR  ( 4175): pkgmgr.c: __pkgmgr_client_uninstall(2186) > uninstall pkg finish, ret=[41750002]
09-09 11:45:26.930+0200 E/PKGMGR_SERVER( 4178): pkgmgr-server.c: queue_job(1962) > UNINSTALL start, pkgid=[co.za.littlekidogo.watchapp]
09-09 11:45:27.020+0200 E/rpm-installer( 4178): rpm-appcore-intf.c: main(120) > ------------------------------------------------
09-09 11:45:27.020+0200 E/rpm-installer( 4178): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
09-09 11:45:27.025+0200 E/rpm-installer( 4178): rpm-appcore-intf.c: main(122) > ------------------------------------------------
09-09 11:45:27.125+0200 E/rpm-installer( 4178): rpm-cmdline.c: __ri_is_core_tpk_app(358) > This is a core tpk app.
09-09 11:45:27.225+0200 W/W_HOME  ( 1088): clock_event.c: _pkgmgr_event_cb(194) > Pkg:co.za.littlekidogo.watchapp is being uninstalled
09-09 11:45:27.225+0200 W/W_HOME  ( 1088): dbox.c: uninstall_cb(1434) > uninstalled:co.za.littlekidogo.watchapp
09-09 11:45:27.240+0200 W/AUL_AMD (  509): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(co.za.littlekidogo.watchapp), key(start), value(uninstall)
09-09 11:45:27.240+0200 W/AUL_AMD (  509): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(997) > __amd_pkgmgrinfo_start_handler
09-09 11:45:27.250+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_cb_log_package(4750) > package [_________] callback : [UNINSTALL, STARTED]
09-09 11:45:27.265+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
09-09 11:45:27.265+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-09 11:45:27.265+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 9-9-2018, 09:59:59 (UTC).
09-09 11:45:27.265+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-09 11:45:27.265+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __save_module_log(1780) > The file is not ready.
09-09 11:45:27.290+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
09-09 11:45:27.295+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 14
09-09 11:45:27.305+0200 W/AUL_AMD (  509): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
09-09 11:45:27.335+0200 E/PKGMGR_PARSER( 4178): pkgmgr_parser_signature.c: __ps_check_mdm_policy_by_pkgid(1056) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
09-09 11:45:27.475+0200 E/PKGMGR_CERT( 4178): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(616) > Transaction Begin
09-09 11:45:27.475+0200 E/PKGMGR_CERT( 4178): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(621) > Certificate Deletion Success
09-09 11:45:27.490+0200 E/PKGMGR_CERT( 4178): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(634) > Transaction Commit and End
09-09 11:45:27.495+0200 E/rpm-installer( 4178): coretpk-installer.c: _coretpk_installer_uninstall_package(4163) > success
09-09 11:45:27.495+0200 E/rpm-installer( 4178): coretpk-installer.c: _coretpk_installer_uninstall_package(4164) > try to classify and delete residual files
09-09 11:45:27.515+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 4022 pgid = 4022
09-09 11:45:27.515+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
09-09 11:45:27.555+0200 E/STORAGE_CLEANER( 4178): storage-cleaner.c: __create_handle(448) > Failed to prepare stmt
09-09 11:45:27.630+0200 I/AUL_AMD (  509): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4022
09-09 11:45:27.630+0200 W/AUL     (  509): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(4022)
09-09 11:45:27.710+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
09-09 11:45:27.710+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 3943 pgid = -1
09-09 11:45:27.710+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
09-09 11:45:27.710+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
09-09 11:45:27.720+0200 I/AUL_AMD (  509): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 3943
09-09 11:45:27.720+0200 W/AUL     (  509): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(3943)
09-09 11:45:29.050+0200 I/AUL_AMD (  509): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 3941
09-09 11:45:29.050+0200 W/AUL     (  509): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(3941)
09-09 11:45:29.485+0200 E/PKGMGR_SERVER( 4177): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
09-09 11:45:29.525+0200 E/PUSHD   ( 1171): db.c: _get_app_info_by_query(316) > DB step: 101 [unknown error]
09-09 11:45:29.525+0200 E/PUSHD   ( 1171): db.c: db_reg_get_by_tizen_pkg_id(393) > Fail to get app_info
09-09 11:45:29.530+0200 W/W_HOME  ( 1088): clock_event.c: _pkgmgr_event_cb(226) > Pkg:co.za.littlekidogo.watchapp is uninstalled, delete related resource
09-09 11:45:29.530+0200 W/W_HOME  ( 1088): clock_event.c: _pkgmgr_event_cb(230) > attacheck clock:com.samsung.watchface
09-09 11:45:29.530+0200 W/W_HOME  ( 1088): dbox.c: uninstall_cb(1434) > uninstalled:co.za.littlekidogo.watchapp
09-09 11:45:29.540+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: onRemoveItem(466) >  [watchapp]
09-09 11:45:29.540+0200 W/APPS    ( 1088): AppsItem.cpp: setLastIndex(1280) >  This is last index app [13:Galaxy Apps], focusIdx[14]
09-09 11:45:29.540+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
09-09 11:45:29.540+0200 W/APPS    ( 1088): AppsItem.cpp: onItemBadgeRemove(864) >  [watchapp] remove badge db
09-09 11:45:29.560+0200 W/AUL_AMD (  509): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(co.za.littlekidogo.watchapp), key(end), value(ok)
09-09 11:45:29.560+0200 W/AUL_AMD (  509): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1037) > g_hash_table_foreach_remove, 1
09-09 11:45:29.585+0200 E/STARTER (  964): pkg-monitor.c: _pkg_monitor_get_mainappid(105) > [_pkg_monitor_get_mainappid:105] Failed to get pkginfo[-1]
09-09 11:45:29.635+0200 E/rpm-installer( 4178): rpm-appcore-intf.c: main(273) > ------------------------------------------------
09-09 11:45:29.635+0200 E/rpm-installer( 4178): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
09-09 11:45:29.635+0200 E/rpm-installer( 4178): rpm-appcore-intf.c: main(275) > ------------------------------------------------
09-09 11:45:29.640+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
09-09 11:45:29.640+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_cb_log_package(4750) > package [_________] callback : [UNINSTALL, COMPLETED]
09-09 11:45:29.640+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7029) > package uninstall complete
09-09 11:45:29.640+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7035) > disabled_pkg_list : 
09-09 11:45:29.640+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_package_uninstall_event(4929) > 
09-09 11:45:29.640+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(2046) > Found in install_req_list?[0], index[-1]
09-09 11:45:29.640+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_package_uninstall_event(4935) > installe_req_list is NULL.
09-09 11:45:29.640+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-09 11:45:29.640+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 9-9-2018, 09:59:59 (UTC).
09-09 11:45:29.640+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-09 11:45:29.640+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __save_module_log(1780) > The file is not ready.
09-09 11:45:29.660+0200 E/PKGMGR_SERVER( 4177): pkgmgr-server.c: sighandler(486) > child NORMAL exit [4178]
09-09 11:45:29.665+0200 E/WMS     (  526): wms_db.c: wms_db_package_event_insert_record(190) > 
09-09 11:45:29.685+0200 E/EFL     ( 1088): elementary<1088> elm_layout.c:1021 _elm_layout_smart_content_set() could not swallow 0x487e3230 into part 'elm.swallow.event.0'
09-09 11:45:29.700+0200 W/APPS    ( 1088): AppsItem.cpp: setLastIndex(1280) >  This is last index app [13:Galaxy Apps], focusIdx[13]
09-09 11:45:29.705+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
09-09 11:45:29.705+0200 W/APPS    ( 1088): AppsItem.cpp: aniFocusIndex(2373) >  [Galaxy Apps:13] Focused[0], focusIdx[13]
09-09 11:45:29.710+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
09-09 11:45:29.710+0200 W/APPS    ( 1088): db.c: apps_db_read_list(621) >  
09-09 11:45:29.715+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
09-09 11:45:29.720+0200 E/RESOURCED(  681): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/4178/oom_score_adj failed
09-09 11:45:29.720+0200 E/RESOURCED(  681): proc-main.c: resourced_proc_status_change(1501) > Empty pid or process not exists. 4178
09-09 11:45:29.930+0200 E/PKGMGR  ( 4190): pkgmgr.c: pkgmgr_client_install(1651) > install pkg start.
09-09 11:45:30.025+0200 E/PKGMGR  ( 4177): pkgmgr-internal.c: _get_type_from_zip(771) > /opt/usr/apps/tmp/co.za.littlekidogo.watchapp-1.0.0-arm.tpk is core
09-09 11:45:30.025+0200 E/PKGMGR  ( 4177): pkgmgr-internal.c: _get_type_from_zip(771) > /opt/usr/apps/tmp/co.za.littlekidogo.watchapp-1.0.0-arm.tpk is core
09-09 11:45:30.030+0200 E/rpm-installer( 4177): installer-util.c: _installer_util_delete_dir(420) > (dp == NULL) opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
09-09 11:45:30.035+0200 E/BACKEND_LIB( 4177): librpm.c: __is_symlink_file(70) > file is safe
09-09 11:45:30.040+0200 E/PKGMGR_SERVER( 4177): pm-mdm.c: _pm_get_signature_info_from_file(1364) > open : fd == -1, err=[1118711444]
09-09 11:45:30.055+0200 E/PKGMGR_SERVER( 4177): pm-mdm.c: _pm_check_mdm_policy(1078) > [0;31m[_pm_check_mdm_policy(): 1078](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
09-09 11:45:30.060+0200 E/PKGMGR  ( 4190): pkgmgr.c: pkgmgr_client_install(1768) > install pkg finish, ret=[41900002]
09-09 11:45:30.070+0200 E/PKGMGR_SERVER( 4192): pkgmgr-server.c: queue_job(2138) > COMM_REQ_OBSERVER start, pkgid=[]
09-09 11:45:30.080+0200 E/PKGMGR_SERVER( 4193): pkgmgr-server.c: queue_job(1944) > INSTALL start, pkg path=[/opt/usr/apps/tmp/co.za.littlekidogo.watchapp-1.0.0-arm.tpk]
09-09 11:45:30.255+0200 E/rpm-installer( 4193): rpm-appcore-intf.c: main(120) > ------------------------------------------------
09-09 11:45:30.255+0200 E/rpm-installer( 4193): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
09-09 11:45:30.255+0200 E/rpm-installer( 4193): rpm-appcore-intf.c: main(122) > ------------------------------------------------
09-09 11:45:30.300+0200 E/PKGMGR_OBSERVER( 4192): pkg_observer.c: main(601) > OBSERVER start
09-09 11:45:30.390+0200 E/rpm-installer( 4193): rpm-appcore-intf.c: main(207) > [/opt/usr/apps/tmp/co.za.littlekidogo.watchapp-1.0.0-arm.tpk] is tpk package.
09-09 11:45:30.395+0200 E/rpm-installer( 4193): coretpk-parser.c: __coretpk_parser_get_value(1713) > (result_value == NULL) [install-location] is empty.
09-09 11:45:30.395+0200 E/rpm-installer( 4193): coretpk-parser.c: __coretpk_parser_get_value_list(1670) > (ret == 1) [//*[name() ='privileges']/*[name()='privilege']] is empty.
09-09 11:45:30.405+0200 E/rpm-installer( 4193): coretpk-parser.c: _coretpk_parser_is_widget(1586) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget'])
09-09 11:45:30.405+0200 E/rpm-installer( 4193): coretpk-parser.c: _coretpk_parser_is_custom_clock(1480) > (ret == 1) metadata(watchface) is empty.
09-09 11:45:30.410+0200 E/rpm-installer( 4193): installer-util.c: _installer_util_delete_dir(420) > (dp == NULL) opendir(/opt/usr/data/pkgmgr/co.za.littlekidogo.watchapp/) failed. [2][No such file or directory]
09-09 11:45:30.410+0200 E/rpm-installer( 4193): coretpk-installer.c: _coretpk_installer_install_package(3579) > Deletion failed: [/opt/usr/data/pkgmgr/co.za.littlekidogo.watchapp/]
09-09 11:45:30.530+0200 E/PKGMGR_OBSERVER( 4192): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[41920002] pkg_type[tpk] pkgid[co.za.littlekidogo.watchapp] key[start] val[install]
09-09 11:45:30.560+0200 W/AUL_AMD (  509): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(co.za.littlekidogo.watchapp), key(start), value(install)
09-09 11:45:30.560+0200 E/PKGMGR_OBSERVER( 4192): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[41920002] pkg_type[tpk] pkgid[co.za.littlekidogo.watchapp] key[install_percent] val[30]
09-09 11:45:30.585+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_cb_log_package(4750) > package [_________] callback : [INSTALL, STARTED]
09-09 11:45:30.620+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_cb_log_package(4750) > package [_________] callback : [INSTALL, PROCESSING]
09-09 11:45:30.760+0200 W/CERT_SVC( 4193): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
09-09 11:45:30.785+0200 E/rpm-installer( 4193): coretpk-parser.c: __coretpk_parser_verify_metadata(48) > (ret == 1) metadata is empty.
09-09 11:45:30.785+0200 E/rpm-installer( 4193): coretpk-parser.c: __coretpk_parser_append_path(417) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
09-09 11:45:30.785+0200 E/rpm-installer( 4193): coretpk-parser.c: __coretpk_parser_append_path(417) > (ret == 1) NodeSet is empty. (//*[name()='widget-application']//*[name()='support-size']/@preview)
09-09 11:45:30.790+0200 E/rpm-installer( 4193): coretpk-parser.c: __coretpk_parser_widget_replace_widget_tag(541) > (ret == 1) NodeSet is empty. (//*[name() = 'widget-application'])
09-09 11:45:30.870+0200 E/PKGMGR_PARSER( 4193): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2167) > Manifest is Valid
09-09 11:45:30.880+0200 E/PKGMGR_PARSER( 4193): pkgmgr_parser.c: __parse_manifest_for_installation(1910) > parsing manifest for installation: /opt/share/packages/co.za.littlekidogo.watchapp.xml
09-09 11:45:30.885+0200 E/PKGMGR_PARSER( 4193): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
09-09 11:45:30.885+0200 E/PKGMGR_PARSER( 4193): pkgmgr_parser.c: __ps_process_tag(866) > tag is NULL
09-09 11:45:31.045+0200 I/efl-extension( 4193): efl_extension.c: eext_mod_init(40) > Init
09-09 11:45:31.045+0200 I/efl-extension( 4193): efl_extension.c: eext_mod_shutdown(46) > Shutdown
09-09 11:45:31.135+0200 E/PKGMGR_PARSER( 4193): pkgmgr_parser.c: __parse_manifest_for_installation(1952) > parsing manifest for installation Done
09-09 11:45:31.160+0200 E/PKGMGR_CERT( 4193): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
09-09 11:45:31.160+0200 E/PKGMGR_CERT( 4193): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 106
09-09 11:45:31.165+0200 E/PKGMGR_CERT( 4193): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 106
09-09 11:45:31.165+0200 E/PKGMGR_CERT( 4193): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 18 1
09-09 11:45:31.165+0200 E/PKGMGR_CERT( 4193): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 19 1
09-09 11:45:31.165+0200 E/PKGMGR_CERT( 4193): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 20 1
09-09 11:45:31.170+0200 E/PKGMGR_CERT( 4193): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 21 1
09-09 11:45:31.190+0200 E/PKGMGR_CERT( 4193): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(575) > Transaction Commit and End
09-09 11:45:31.205+0200 E/PKGMGR_OBSERVER( 4192): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[41920002] pkg_type[tpk] pkgid[co.za.littlekidogo.watchapp] key[install_percent] val[60]
09-09 11:45:31.230+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_cb_log_package(4750) > package [_________] callback : [INSTALL, PROCESSING]
09-09 11:45:31.280+0200 E/rpm-installer( 4193): installer-util.c: _installer_util_get_configuration_value(601) > [signature]=[on]
09-09 11:45:31.295+0200 E/rpm-installer( 4193): coretpk-installer.c: _coretpk_installer_apply_smack(3199) > groupid = [w6l2VmL6T64TYV9CBa3rojTUP5k2M5pEdQ7YlS8k4wc=] for shared/trusted.
09-09 11:45:31.330+0200 E/PKGMGR_OBSERVER( 4192): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[41920002] pkg_type[tpk] pkgid[co.za.littlekidogo.watchapp] key[install_percent] val[100]
09-09 11:45:31.345+0200 E/rpm-installer( 4193): coretpk-installer.c: __post_install_for_mmc(742) > (handle == NULL) handle is NULL.
09-09 11:45:31.350+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_cb_log_package(4750) > package [_________] callback : [INSTALL, PROCESSING]
09-09 11:45:31.415+0200 E/rpm-installer( 4193): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
09-09 11:45:31.485+0200 E/PKGMGR_SERVER( 4177): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
09-09 11:45:31.645+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 4182 pgid = 1235
09-09 11:45:31.645+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
09-09 11:45:31.715+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
09-09 11:45:31.720+0200 I/AUL_AMD (  509): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4182
09-09 11:45:31.720+0200 W/AUL     (  509): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(4182)
09-09 11:45:31.775+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 4181 pgid = 1235
09-09 11:45:31.775+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
09-09 11:45:31.835+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
09-09 11:45:31.840+0200 I/AUL_AMD (  509): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4181
09-09 11:45:31.840+0200 W/AUL     (  509): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(4181)
09-09 11:45:31.885+0200 I/AUL_AMD (  509): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4180
09-09 11:45:31.885+0200 W/AUL     (  509): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(4180)
09-09 11:45:33.310+0200 E/PKGMGR_OBSERVER( 4192): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[41920002] pkg_type[tpk] pkgid[co.za.littlekidogo.watchapp] key[end] val[ok]
09-09 11:45:33.360+0200 W/AUL_AMD (  509): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(co.za.littlekidogo.watchapp), key(end), value(ok)
09-09 11:45:33.400+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_cb_log_package(4750) > package [_________] callback : [INSTALL, COMPLETED]
09-09 11:45:33.400+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7086) > package install complete
09-09 11:45:33.400+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_package_install_event(5040) > 
09-09 11:45:33.400+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(2046) > Found in install_req_list?[0], index[-1]
09-09 11:45:33.400+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_package_install_event(5066) > triggered from Gear itself.
09-09 11:45:33.435+0200 E/STARTER (  964): pkg-monitor.c: _pkg_monitor_get_metadata(136) > [_pkg_monitor_get_metadata:136] Failed to get metadata value[-2]
09-09 11:45:33.460+0200 E/PKGMGR_INFO( 4192): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(1026) > callback is stopped.
09-09 11:45:33.470+0200 E/PKGMGR_OBSERVER( 4192): pkg_observer.c: main(620) > OBSERVER end
09-09 11:45:33.485+0200 E/PKGMGR_SERVER( 4177): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
09-09 11:45:33.505+0200 E/PKGMGR_INFO(  525): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(922) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
09-09 11:45:33.505+0200 E/WMS     (  526): wms_db.c: wms_db_package_event_insert_record(190) > 
09-09 11:45:33.510+0200 E/PKGMGR_SERVER( 4177): pkgmgr-server.c: sighandler(486) > child NORMAL exit [4192]
09-09 11:45:33.525+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: onAddItem(356) >  [watchapp]
09-09 11:45:33.785+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2892) > send_install_response completed : END
09-09 11:45:33.915+0200 W/APPS    ( 1088): AppsBadge.cpp: onBadgeInit(124) >  [watchapp] Badge is not exist
09-09 11:45:33.915+0200 W/APPS    ( 1088): AppsItem.cpp: setLastIndex(1273) >  This is not last index app [13:Galaxy Apps]
09-09 11:45:33.920+0200 E/Vi::Animations( 1088): result Vi::Animations::_AnimationManager::addAnimation(Vi::Animations::Visual&, const string*, Vi::Animations::Animation&)(288) > [E_OBJ_ALREADY_EXIST] Animation with keyName already exists. key name = hide
09-09 11:45:33.920+0200 I/Vi::Animations( 1088): result Vi::Animations::_VisualImpl::addAnimation(const string*, Vi::Animations::Animation&)(6999) > [E_OBJ_ALREADY_EXIST] Propagating.
09-09 11:45:33.920+0200 W/APPS    ( 1088): AppsItem.cpp: setLastIndex(1280) >  This is last index app [14:watchapp], focusIdx[13]
09-09 11:45:33.920+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
09-09 11:45:33.925+0200 E/EFL     ( 1088): elementary<1088> elm_layout.c:1021 _elm_layout_smart_content_set() could not swallow 0x487e3230 into part 'elm.swallow.event.0'
09-09 11:45:33.930+0200 W/APPS    ( 1088): AppsItem.cpp: aniFocusIndex(2373) >  [Galaxy Apps:13] Focused[1], focusIdx[13]
09-09 11:45:33.930+0200 W/APPS    ( 1088): AppsItem.cpp: setLastIndex(1280) >  This is last index app [14:watchapp], focusIdx[13]
09-09 11:45:33.935+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
09-09 11:45:33.935+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
09-09 11:45:33.935+0200 W/APPS    ( 1088): db.c: apps_db_read_list(621) >  
09-09 11:45:35.075+0200 W/W_INDICATOR( 1003): windicator_battery.c: windicator_battery_update(98) > [windicator_battery_update:98] 
09-09 11:45:35.075+0200 W/W_INDICATOR( 1003): windicator_battery.c: _battery_icon_update(313) > [_battery_icon_update:313] battery level(31), length(2)
09-09 11:45:35.075+0200 W/W_INDICATOR( 1003): windicator_battery.c: _battery_icon_update(337) > [_battery_icon_update:337] 31%
09-09 11:45:35.075+0200 W/W_INDICATOR( 1003): windicator_battery.c: _battery_icon_update(352) > [_battery_icon_update:352] battery_level: 31, isCharging: 0
09-09 11:45:35.075+0200 W/W_INDICATOR( 1003): windicator_battery.c: _battery_icon_update(386) > [_battery_icon_update:386] battery file : change_level_35
09-09 11:45:35.075+0200 W/W_INDICATOR( 1003): windicator_battery.c: _battery_icon_update(526) > [_battery_icon_update:526] Normal charging status !!
09-09 11:45:35.360+0200 E/rpm-installer( 4193): rpm-appcore-intf.c: main(273) > ------------------------------------------------
09-09 11:45:35.360+0200 E/rpm-installer( 4193): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
09-09 11:45:35.360+0200 E/rpm-installer( 4193): rpm-appcore-intf.c: main(275) > ------------------------------------------------
09-09 11:45:35.385+0200 E/PKGMGR_SERVER( 4177): pkgmgr-server.c: sighandler(486) > child NORMAL exit [4193]
09-09 11:45:35.485+0200 E/PKGMGR_SERVER( 4177): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
09-09 11:45:35.485+0200 E/PKGMGR_SERVER( 4177): pkgmgr-server.c: main(2296) > package manager server terminated.
09-09 11:45:35.495+0200 E/RESOURCED(  681): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/4193/oom_score_adj failed
09-09 11:45:35.495+0200 E/RESOURCED(  681): proc-main.c: resourced_proc_status_change(1501) > Empty pid or process not exists. 4193
09-09 11:45:35.605+0200 W/AUL     ( 4219): launch.c: app_request_to_launchpad(284) > request cmd(0) to(co.za.littlekidogo.watchapp)
09-09 11:45:35.605+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 0
09-09 11:45:35.620+0200 I/AUL_AMD (  509): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
09-09 11:45:35.635+0200 I/AUL_AMD (  509): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
09-09 11:45:35.635+0200 E/AUL_AMD (  509): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
09-09 11:45:35.635+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(1782) > caller pid : 4219
09-09 11:45:35.650+0200 E/RESOURCED(  681): block.c: block_prelaunch_state(138) > insert data co.za.littlekidogo.watchapp, table num : 2
09-09 11:45:35.655+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(2218) > pad pid(-5)
09-09 11:45:35.655+0200 W/AUL_PAD ( 1235): launchpad.c: __launchpad_main_loop(630) > Candidate is not prepared, enter legacy logic
09-09 11:45:35.655+0200 W/AUL_PAD ( 1235): launchpad.c: __send_result_to_caller(272) > Check app launching
09-09 11:45:35.655+0200 E/AUL_PAD ( 1235): launchpad.c: __send_result_to_caller(278) > launching failed
09-09 11:45:35.655+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(2229) > Launch with legacy way : no launchpad
09-09 11:45:35.660+0200 W/AUL_AMD (  509): amd_launch.c: start_process(606) > child process: 4220
09-09 11:45:35.710+0200 W/AUL_AMD (  509): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 4220
09-09 11:45:35.710+0200 W/AUL     (  509): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(co.za.littlekidogo.watchapp) pid(4220) type(uiapp) bg(0)
09-09 11:45:35.710+0200 W/AUL     ( 4219): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4220)
09-09 11:45:35.715+0200 W/STARTER (  964): pkg-monitor.c: _app_mgr_status_cb(400) > [_app_mgr_status_cb:400] Launch request [4220]
09-09 11:45:35.745+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 14
09-09 11:45:35.755+0200 W/AUL_AMD (  509): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4220
09-09 11:45:35.755+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 12
09-09 11:45:35.935+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 14
09-09 11:45:35.940+0200 W/AUL_AMD (  509): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4220
09-09 11:45:35.945+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 12
09-09 11:45:35.975+0200 I/efl-extension( 4220): efl_extension.c: eext_mod_init(40) > Init
09-09 11:45:36.000+0200 I/CAPI_APPFW_APPLICATION( 4220): app_main.c: ui_app_main(704) > app_efl_main
09-09 11:45:36.040+0200 I/UXT     ( 4220): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
09-09 11:45:36.195+0200 W/AUL_AMD (  509): amd_status.c: __socket_monitor_cb(1277) > (4220) was created
09-09 11:45:36.195+0200 I/CAPI_APPFW_APPLICATION( 4220): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
09-09 11:45:36.280+0200 E/MALI    ( 4220): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
09-09 11:45:36.280+0200 E/MALI    ( 4220): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
09-09 11:45:36.280+0200 E/MALI    ( 4220): [gpu-ddk] devel/graphics_drv/r4p0
09-09 11:45:36.280+0200 E/MALI    ( 4220): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
09-09 11:45:36.280+0200 E/MALI    ( 4220): [coregl] devel/graphics_engine/master
09-09 11:45:36.280+0200 E/MALI    ( 4220): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
09-09 11:45:36.465+0200 E/EFL     ( 4220): ecore_evas<4220> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
09-09 11:45:36.710+0200 W/AUL_AMD (  509): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-09 11:45:36.710+0200 W/AUL_AMD (  509): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
09-09 11:45:36.815+0200 I/AUL_PAD ( 4203): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
09-09 11:45:36.935+0200 W/AUL     ( 4228): daemon-manager-release-agent.c: main(12) > release agent : [2:/co.za.littlekidogo.watchapp]
09-09 11:45:36.935+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 23
09-09 11:45:36.935+0200 W/AUL_AMD (  509): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
09-09 11:45:36.935+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 4220
09-09 11:45:36.935+0200 W/AUL_AMD (  509): amd_request.c: __send_app_termination_signal(528) > send dead signal done
09-09 11:45:36.970+0200 I/AUL_AMD (  509): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4220
09-09 11:45:36.970+0200 W/AUL     (  509): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(4220)
09-09 11:45:37.120+0200 W/CRASH_MANAGER( 4229): worker.c: worker_job(1205) > 1104220776174153648633
