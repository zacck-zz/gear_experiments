S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.7
Build-Number: R732XXU2FRC1
Build-Date: 2018.03.02 17:21:30

Crash Information
Process Name: watchapp
PID: 4029
Date: 2018-09-09 11:44:51+0200
Executable File Path: /opt/usr/apps/co.za.littlekidogo.watchapp/bin/watchapp
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x2

Register Information
r0   = 0x00000002, r1   = 0x00000025
r2   = 0xbe89714c, r3   = 0x00000002
r4   = 0xfbad8001, r5   = 0xbe897030
r6   = 0xbe89714c, r7   = 0x4040b000
r8   = 0x00000000, r9   = 0x00000fbd
r10  = 0x00000002, fp   = 0xbe897024
ip   = 0x4040a9c8, sp   = 0xbe896aa8
lr   = 0x4031af50, pc   = 0x40357928
cpsr = 0x20000010

Memory Information
MemTotal:   490112 KB
MemFree:      6132 KB
Buffers:     26224 KB
Cached:     167584 KB
VmPeak:      82480 KB
VmSize:      82412 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15976 KB
VmRSS:       15976 KB
VmData:      21848 KB
VmStk:         136 KB
VmExe:           8 KB
VmLib:       24612 KB
VmPTE:          50 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 4029 TID = 4029
4029 4034 4035 

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
43a65000 44264000 rw-p [stack:4034]
44265000 44a64000 rw-p [stack:4035]
44d18000 44d2f000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44edf000 44ee0000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
be877000 be898000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4029)
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
ler, pid: 3917
09-09 11:44:27.215+0200 W/AUL     (  509): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(3917)
09-09 11:44:27.220+0200 E/rpm-installer( 3932): coretpk-installer.c: _coretpk_installer_apply_smack(3199) > groupid = [w6l2VmL6T64TYV9CBa3rojTUP5k2M5pEdQ7YlS8k4wc=] for shared/trusted.
09-09 11:44:27.235+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 3915 pgid = 3915
09-09 11:44:27.235+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
09-09 11:44:27.255+0200 E/rpm-installer( 3932): coretpk-installer.c: __post_install_for_mmc(742) > (handle == NULL) handle is NULL.
09-09 11:44:27.280+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
09-09 11:44:27.280+0200 I/AUL_AMD (  509): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 3915
09-09 11:44:27.280+0200 W/AUL     (  509): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(3915)
09-09 11:44:27.285+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 3916 pgid = 3916
09-09 11:44:27.285+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
09-09 11:44:27.305+0200 E/rpm-installer( 3932): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
09-09 11:44:27.305+0200 E/PKGMGR_OBSERVER( 3931): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[39310002] pkg_type[tpk] pkgid[co.za.littlekidogo.watchapp] key[install_percent] val[100]
09-09 11:44:27.375+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
09-09 11:44:27.375+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_cb_log_package(4750) > package [_________] callback : [INSTALL, PROCESSING]
09-09 11:44:27.380+0200 I/AUL_AMD (  509): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 3916
09-09 11:44:27.380+0200 W/AUL     (  509): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(3916)
09-09 11:44:27.485+0200 E/PKGMGR_SERVER( 3911): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
09-09 11:44:28.050+0200 I/AUL_PAD ( 3942): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
09-09 11:44:28.420+0200 I/efl-extension( 1242): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 11:44:28.420+0200 I/efl-extension( 1003): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 11:44:28.425+0200 I/efl-extension( 1088): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 11:44:28.425+0200 I/efl-extension( 1088): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x47c25398, elm_layout, time_stamp : 2382938
09-09 11:44:28.425+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: onRotary(5387) >  __nTimeStamp:[0], __isFastMoving[0]
09-09 11:44:28.425+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: runRotaryForwardAnimation(3600) >  EditMode[0], focusPage[1], focusIndex[13], ItemListSize[14], FocusPrev[0], FocusNext[0], FocusRecent[0], HideNextPage[0]
09-09 11:44:28.425+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
09-09 11:44:28.975+0200 I/efl-extension( 3943): efl_extension.c: eext_mod_init(40) > Init
09-09 11:44:29.095+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: onAutoLaunchTimerStart(5026) >  auto launch is disabled
09-09 11:44:29.155+0200 I/UXT     ( 3943): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
09-09 11:44:29.255+0200 E/PKGMGR_OBSERVER( 3931): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[39310002] pkg_type[tpk] pkgid[co.za.littlekidogo.watchapp] key[end] val[ok]
09-09 11:44:29.295+0200 W/AUL_AMD (  509): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(co.za.littlekidogo.watchapp), key(end), value(ok)
09-09 11:44:29.330+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_cb_log_package(4750) > package [_________] callback : [INSTALL, COMPLETED]
09-09 11:44:29.330+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7086) > package install complete
09-09 11:44:29.330+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_package_install_event(5040) > 
09-09 11:44:29.330+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(2046) > Found in install_req_list?[0], index[-1]
09-09 11:44:29.330+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_package_install_event(5066) > triggered from Gear itself.
09-09 11:44:29.375+0200 E/STARTER (  964): pkg-monitor.c: _pkg_monitor_get_metadata(136) > [_pkg_monitor_get_metadata:136] Failed to get metadata value[-2]
09-09 11:44:29.385+0200 E/PKGMGR_INFO( 3931): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(1026) > callback is stopped.
09-09 11:44:29.390+0200 E/WMS     (  526): wms_db.c: wms_db_package_event_insert_record(190) > 
09-09 11:44:29.400+0200 E/PKGMGR_INFO(  525): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(922) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
09-09 11:44:29.415+0200 E/PKGMGR_OBSERVER( 3931): pkg_observer.c: main(620) > OBSERVER end
09-09 11:44:29.425+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: onAddItem(356) >  [watchapp]
09-09 11:44:29.425+0200 E/PKGMGR_SERVER( 3911): pkgmgr-server.c: sighandler(486) > child NORMAL exit [3931]
09-09 11:44:29.475+0200 I/AUL_PAD ( 3943): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
09-09 11:44:29.485+0200 E/PKGMGR_SERVER( 3911): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
09-09 11:44:29.500+0200 E/MALI    ( 3943): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
09-09 11:44:29.500+0200 E/MALI    ( 3943): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
09-09 11:44:29.500+0200 E/MALI    ( 3943): [gpu-ddk] devel/graphics_drv/r4p0
09-09 11:44:29.500+0200 E/MALI    ( 3943): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
09-09 11:44:29.500+0200 E/MALI    ( 3943): [coregl] devel/graphics_engine/master
09-09 11:44:29.500+0200 E/MALI    ( 3943): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
09-09 11:44:29.670+0200 E/WMS     (  526): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2892) > send_install_response completed : END
09-09 11:44:29.735+0200 W/APPS    ( 1088): AppsBadge.cpp: onBadgeInit(124) >  [watchapp] Badge is not exist
09-09 11:44:29.735+0200 W/APPS    ( 1088): AppsItem.cpp: setLastIndex(1273) >  This is not last index app [13:Galaxy Apps]
09-09 11:44:29.735+0200 E/Vi::Animations( 1088): result Vi::Animations::_AnimationManager::addAnimation(Vi::Animations::Visual&, const string*, Vi::Animations::Animation&)(288) > [E_OBJ_ALREADY_EXIST] Animation with keyName already exists. key name = hide
09-09 11:44:29.735+0200 I/Vi::Animations( 1088): result Vi::Animations::_VisualImpl::addAnimation(const string*, Vi::Animations::Animation&)(6999) > [E_OBJ_ALREADY_EXIST] Propagating.
09-09 11:44:29.735+0200 W/APPS    ( 1088): AppsItem.cpp: setLastIndex(1280) >  This is last index app [14:watchapp], focusIdx[13]
09-09 11:44:29.735+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
09-09 11:44:29.740+0200 E/EFL     ( 1088): elementary<1088> elm_layout.c:1021 _elm_layout_smart_content_set() could not swallow 0x487e3230 into part 'elm.swallow.event.0'
09-09 11:44:29.740+0200 W/APPS    ( 1088): AppsItem.cpp: aniFocusIndex(2373) >  [Galaxy Apps:13] Focused[1], focusIdx[13]
09-09 11:44:29.740+0200 W/APPS    ( 1088): AppsItem.cpp: setLastIndex(1280) >  This is last index app [14:watchapp], focusIdx[13]
09-09 11:44:29.740+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
09-09 11:44:29.740+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
09-09 11:44:29.740+0200 W/APPS    ( 1088): db.c: apps_db_read_list(621) >  
09-09 11:44:29.870+0200 W/MM_CAMCORDER( 3941): mm_camcorder_internal.c: _mmcamcorder_constructor(203) >  start
09-09 11:44:29.870+0200 W/MM_CAMCORDER( 3941): mm_camcorder_internal.c: _mmcamcorder_constructor(213) >  done
09-09 11:44:29.875+0200 I/efl-extension( 3941): efl_extension.c: eext_mod_init(40) > Init
09-09 11:44:30.795+0200 I/AUL     ( 3941): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 11:44:30.810+0200 I/AUL     ( 3941): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 11:44:30.810+0200 E/AUL     ( 3941): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
09-09 11:44:30.810+0200 E/AUL     ( 3941): aul_path.c: __get_path(169) > root_path is NULL!
09-09 11:44:30.820+0200 I/AUL     ( 3941): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 11:44:30.830+0200 I/AUL     ( 3941): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 11:44:30.830+0200 E/AUL     ( 3941): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
09-09 11:44:30.830+0200 E/AUL     ( 3941): aul_path.c: __get_path(169) > root_path is NULL!
09-09 11:44:30.845+0200 I/AUL     ( 3941): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 11:44:30.855+0200 I/AUL     ( 3941): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 11:44:30.855+0200 E/AUL     ( 3941): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
09-09 11:44:30.855+0200 E/AUL     ( 3941): aul_path.c: __get_path(169) > root_path is NULL!
09-09 11:44:30.870+0200 I/AUL     ( 3941): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 11:44:30.890+0200 I/AUL     ( 3941): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 11:44:30.890+0200 E/AUL     ( 3941): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
09-09 11:44:30.890+0200 E/AUL     ( 3941): aul_path.c: __get_path(169) > root_path is NULL!
09-09 11:44:30.900+0200 I/AUL     ( 3941): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 11:44:30.930+0200 I/AUL     ( 3941): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 11:44:30.930+0200 E/AUL     ( 3941): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
09-09 11:44:30.930+0200 E/AUL     ( 3941): aul_path.c: __get_path(169) > root_path is NULL!
09-09 11:44:30.945+0200 I/AUL     ( 3941): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 11:44:30.960+0200 I/AUL     ( 3941): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 11:44:30.960+0200 E/AUL     ( 3941): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
09-09 11:44:30.960+0200 E/AUL     ( 3941): aul_path.c: __get_path(169) > root_path is NULL!
09-09 11:44:30.975+0200 I/AUL     ( 3941): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 11:44:30.990+0200 I/AUL     ( 3941): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 11:44:30.990+0200 E/AUL     ( 3941): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
09-09 11:44:30.990+0200 E/AUL     ( 3941): aul_path.c: __get_path(169) > root_path is NULL!
09-09 11:44:31.015+0200 I/AUL     ( 3941): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 11:44:31.025+0200 I/AUL     ( 3941): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 11:44:31.025+0200 E/AUL     ( 3941): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
09-09 11:44:31.025+0200 E/AUL     ( 3941): aul_path.c: __get_path(169) > root_path is NULL!
09-09 11:44:31.135+0200 I/UXT     ( 3941): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
09-09 11:44:31.235+0200 E/rpm-installer( 3932): rpm-appcore-intf.c: main(273) > ------------------------------------------------
09-09 11:44:31.235+0200 E/rpm-installer( 3932): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
09-09 11:44:31.235+0200 E/rpm-installer( 3932): rpm-appcore-intf.c: main(275) > ------------------------------------------------
09-09 11:44:31.260+0200 E/PKGMGR_SERVER( 3911): pkgmgr-server.c: sighandler(486) > child NORMAL exit [3932]
09-09 11:44:31.300+0200 E/MALI    ( 3941): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
09-09 11:44:31.300+0200 E/MALI    ( 3941): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
09-09 11:44:31.300+0200 E/MALI    ( 3941): [gpu-ddk] devel/graphics_drv/r4p0
09-09 11:44:31.300+0200 E/MALI    ( 3941): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
09-09 11:44:31.300+0200 E/MALI    ( 3941): [coregl] devel/graphics_engine/master
09-09 11:44:31.300+0200 E/MALI    ( 3941): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
09-09 11:44:31.490+0200 E/PKGMGR_SERVER( 3911): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
09-09 11:44:31.490+0200 E/PKGMGR_SERVER( 3911): pkgmgr-server.c: main(2296) > package manager server terminated.
09-09 11:44:31.495+0200 W/W_INDICATOR( 1003): windicator_connection.c: _wifi_state_changed_cb(930) > [_wifi_state_changed_cb:930] wifi state : 2
09-09 11:44:31.495+0200 W/W_INDICATOR( 1003): windicator_connection.c: _wifi_state_changed_cb(974) > [_wifi_state_changed_cb:974] ap_name : (squirrel2GHZ)
09-09 11:44:31.495+0200 W/W_INDICATOR( 1003): windicator_connection.c: _wifi_state_changed_cb(994) > [_wifi_state_changed_cb:994] wifi strength : 3
09-09 11:44:31.495+0200 W/W_INDICATOR( 1003): windicator_connection.c: _connection_icon_set(713) > [_connection_icon_set:713] type : 15 / signal : type_wifi_connected_03
09-09 11:44:31.495+0200 E/W_INDICATOR( 1003): windicator_connection.c: _connection_icon_set(754) > [_connection_icon_set:754] Set Connection / show sw.icon_1 (15)(0)
09-09 11:44:31.500+0200 W/W_INDICATOR( 1003): windicator_connection.c: _packet_type_changed_cb(1251) > [_packet_type_changed_cb:1251] _packet_type_changed_cb
09-09 11:44:31.500+0200 E/W_INDICATOR( 1003): windicator_connection.c: _packet_type_changed_cb(1261) > [_packet_type_changed_cb:1261] WIFI MODE
09-09 11:44:31.500+0200 W/W_INDICATOR( 1003): windicator_connection.c: _packet_icon_set(840) > [_packet_icon_set:840] packet : 3 / signal : packet_inout_connected
09-09 11:44:31.565+0200 W/AUL     ( 3967): launch.c: app_request_to_launchpad(284) > request cmd(0) to(co.za.littlekidogo.watchapp)
09-09 11:44:31.565+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 0
09-09 11:44:31.580+0200 I/AUL_AMD (  509): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
09-09 11:44:31.590+0200 I/AUL_AMD (  509): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
09-09 11:44:31.590+0200 E/AUL_AMD (  509): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
09-09 11:44:31.590+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(1782) > caller pid : 3967
09-09 11:44:31.600+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(2218) > pad pid(-5)
09-09 11:44:31.605+0200 W/AUL_PAD ( 1235): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
09-09 11:44:31.605+0200 W/AUL_PAD ( 1235): launchpad.c: __send_result_to_caller(272) > Check app launching
09-09 11:44:31.605+0200 W/AUL_PAD ( 3942): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
09-09 11:44:31.605+0200 W/AUL_PAD ( 3942): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
09-09 11:44:31.605+0200 W/AUL_PAD ( 3942): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
09-09 11:44:31.605+0200 W/AUL_PAD ( 3942): launchpad_loader.c: main(680) > [candidate] dlopen(co.za.littlekidogo.watchapp)
09-09 11:44:31.615+0200 E/RESOURCED(  681): block.c: block_prelaunch_state(138) > insert data co.za.littlekidogo.watchapp, table num : 2
09-09 11:44:31.660+0200 I/efl-extension( 3942): efl_extension.c: eext_mod_init(40) > Init
09-09 11:44:31.665+0200 I/UXT     ( 3942): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
09-09 11:44:31.665+0200 W/AUL_PAD ( 3942): launchpad_loader.c: main(690) > [candidate] dlsym
09-09 11:44:31.665+0200 W/AUL_PAD ( 3942): launchpad_loader.c: main(694) > [candidate] dl_main(co.za.littlekidogo.watchapp)
09-09 11:44:31.670+0200 I/CAPI_APPFW_APPLICATION( 3942): app_main.c: ui_app_main(704) > app_efl_main
09-09 11:44:31.675+0200 I/CAPI_APPFW_APPLICATION( 3942): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
09-09 11:44:31.705+0200 W/AUL     (  509): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(co.za.littlekidogo.watchapp) pid(3942) type(uiapp) bg(0)
09-09 11:44:31.705+0200 W/AUL     ( 3967): launch.c: app_request_to_launchpad(298) > request cmd(0) result(3942)
09-09 11:44:31.705+0200 W/AUL_AMD (  509): amd_status.c: __socket_monitor_cb(1277) > (3942) was created
09-09 11:44:31.730+0200 W/STARTER (  964): pkg-monitor.c: _app_mgr_status_cb(400) > [_app_mgr_status_cb:400] Launch request [3942]
09-09 11:44:31.810+0200 E/EFL     ( 3942): ecore_evas<3942> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
09-09 11:44:31.955+0200 W/CRASH_MANAGER( 3781): worker.c: worker_job(1205) > 11039427761741536486271
09-09 11:44:32.300+0200 I/MALI    ( 3941): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [360x360]
09-09 11:44:32.305+0200 E/MALI    ( 3941): egl_mali.c: __egl_mali_post_to_window_surface(1183) > MALI_ERR_EARLY_OUT - Don't need to add frame callback because frame is unmodified
09-09 11:44:32.315+0200 I/AUL     ( 3952): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
09-09 11:44:32.330+0200 I/AUL     ( 3952): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
09-09 11:44:32.330+0200 E/AUL     ( 3952): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
09-09 11:44:32.330+0200 E/AUL     ( 3952): aul_path.c: __get_path(169) > root_path is NULL!
09-09 11:44:32.715+0200 W/AUL_AMD (  509): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-09 11:44:32.715+0200 W/AUL_AMD (  509): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
09-09 11:44:32.910+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 3942 pgid = 3942
09-09 11:44:32.910+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
09-09 11:44:32.920+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __read_proc(55) > file open error : 2
09-09 11:44:32.920+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
09-09 11:44:32.920+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(3942), proc(0)
09-09 11:44:32.920+0200 E/AUL     ( 1272): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
09-09 11:44:32.920+0200 E/CAPI_APPFW_APP_MANAGER( 1272): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
09-09 11:44:32.920+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
09-09 11:44:32.995+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __read_proc(55) > file open error : 2
09-09 11:44:32.995+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
09-09 11:44:32.995+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(3942), proc(0)
09-09 11:44:32.995+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
09-09 11:44:32.995+0200 E/AUL     ( 1374): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
09-09 11:44:32.995+0200 E/CAPI_APPFW_APP_MANAGER( 1374): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
09-09 11:44:33.010+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
09-09 11:44:33.025+0200 I/AUL_AMD (  509): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 3942
09-09 11:44:33.025+0200 W/AUL     (  509): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(3942)
09-09 11:44:33.185+0200 I/AUL_PAD ( 3977): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
09-09 11:44:34.220+0200 W/W_INDICATOR( 1003): windicator_battery.c: windicator_battery_update(98) > [windicator_battery_update:98] 
09-09 11:44:34.220+0200 W/W_INDICATOR( 1003): windicator_battery.c: _battery_icon_update(313) > [_battery_icon_update:313] battery level(32), length(2)
09-09 11:44:34.220+0200 W/W_INDICATOR( 1003): windicator_battery.c: _battery_icon_update(337) > [_battery_icon_update:337] 32%
09-09 11:44:34.220+0200 W/W_INDICATOR( 1003): windicator_battery.c: _battery_icon_update(352) > [_battery_icon_update:352] battery_level: 32, isCharging: 0
09-09 11:44:34.225+0200 W/W_INDICATOR( 1003): windicator_battery.c: _battery_icon_update(386) > [_battery_icon_update:386] battery file : change_level_35
09-09 11:44:34.225+0200 W/W_INDICATOR( 1003): windicator_battery.c: _battery_icon_update(526) > [_battery_icon_update:526] Normal charging status !!
09-09 11:44:41.505+0200 W/W_INDICATOR( 1003): windicator_connection.c: _wifi_state_changed_cb(930) > [_wifi_state_changed_cb:930] wifi state : 2
09-09 11:44:41.505+0200 W/W_INDICATOR( 1003): windicator_connection.c: _wifi_state_changed_cb(974) > [_wifi_state_changed_cb:974] ap_name : (squirrel2GHZ)
09-09 11:44:41.505+0200 W/W_INDICATOR( 1003): windicator_connection.c: _wifi_state_changed_cb(994) > [_wifi_state_changed_cb:994] wifi strength : 4
09-09 11:44:41.505+0200 W/W_INDICATOR( 1003): windicator_connection.c: _connection_icon_set(713) > [_connection_icon_set:713] type : 16 / signal : type_wifi_connected_04
09-09 11:44:41.505+0200 E/W_INDICATOR( 1003): windicator_connection.c: _connection_icon_set(754) > [_connection_icon_set:754] Set Connection / show sw.icon_1 (16)(0)
09-09 11:44:41.505+0200 W/W_INDICATOR( 1003): windicator_connection.c: _packet_type_changed_cb(1251) > [_packet_type_changed_cb:1251] _packet_type_changed_cb
09-09 11:44:41.505+0200 E/W_INDICATOR( 1003): windicator_connection.c: _packet_type_changed_cb(1261) > [_packet_type_changed_cb:1261] WIFI MODE
09-09 11:44:41.505+0200 W/W_INDICATOR( 1003): windicator_connection.c: _packet_icon_set(840) > [_packet_icon_set:840] packet : 3 / signal : packet_inout_connected
09-09 11:44:42.135+0200 I/efl-extension( 1003): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
09-09 11:44:42.135+0200 I/efl-extension( 1088): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
09-09 11:44:42.135+0200 I/efl-extension( 1088): efl_extension_rotary.c: _rotary_rotate_handler_cb(539) > Deliver counter clockwise rotary event to object: 0x47c25398, elm_layout, time_stamp : 2396650
09-09 11:44:42.135+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: onRotary(5387) >  __nTimeStamp:[0], __isFastMoving[0]
09-09 11:44:42.135+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: runRotaryBackwardAnimation(3721) >  EditMode[0], focusPage[1], focusIndex[13], ItemList size[15], FocusPrev[0], FocusNext[0], FocusRecent[0], HideNextPage[0]
09-09 11:44:42.135+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: runFocusAni(3491) >  nNewFocus[12], anim[0], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[15]
09-09 11:44:42.135+0200 I/efl-extension( 1242): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
09-09 11:44:42.135+0200 W/APPS    ( 1088): AppsItem.cpp: aniFocusIndex(2373) >  [Voice Memo:12] Focused[0], focusIdx[12]
09-09 11:44:42.140+0200 W/APPS    ( 1088): AppsItem.cpp: setLastIndex(1280) >  This is last index app [14:watchapp], focusIdx[12]
09-09 11:44:42.140+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
09-09 11:44:42.140+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
09-09 11:44:42.355+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: onAutoLaunchTimerStart(5026) >  auto launch is disabled
09-09 11:44:43.515+0200 I/efl-extension( 1003): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 11:44:43.515+0200 I/efl-extension( 1242): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 11:44:43.520+0200 I/efl-extension( 1088): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 11:44:43.520+0200 I/efl-extension( 1088): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x47c25398, elm_layout, time_stamp : 2398033
09-09 11:44:43.520+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: runRotaryForwardAnimation(3600) >  EditMode[0], focusPage[1], focusIndex[12], ItemListSize[15], FocusPrev[0], FocusNext[0], FocusRecent[0], HideNextPage[0]
09-09 11:44:43.520+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: runFocusAni(3491) >  nNewFocus[13], anim[0], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[15]
09-09 11:44:43.520+0200 W/APPS    ( 1088): AppsItem.cpp: aniFocusIndex(2373) >  [Galaxy Apps:13] Focused[0], focusIdx[13]
09-09 11:44:43.520+0200 W/APPS    ( 1088): AppsItem.cpp: setLastIndex(1280) >  This is last index app [14:watchapp], focusIdx[13]
09-09 11:44:43.520+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
09-09 11:44:43.520+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
09-09 11:44:43.750+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: onAutoLaunchTimerStart(5026) >  auto launch is disabled
09-09 11:44:44.845+0200 I/efl-extension( 1003): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 11:44:44.845+0200 I/efl-extension( 1242): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 11:44:44.850+0200 I/efl-extension( 1088): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 11:44:44.850+0200 I/efl-extension( 1088): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x47c25398, elm_layout, time_stamp : 2399362
09-09 11:44:44.850+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: runRotaryForwardAnimation(3600) >  EditMode[0], focusPage[1], focusIndex[13], ItemListSize[15], FocusPrev[0], FocusNext[0], FocusRecent[0], HideNextPage[0]
09-09 11:44:44.850+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: runFocusAni(3491) >  nNewFocus[14], anim[0], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[15]
09-09 11:44:44.850+0200 W/APPS    ( 1088): AppsItem.cpp: setLastIndex(1280) >  This is last index app [14:watchapp], focusIdx[14]
09-09 11:44:44.850+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
09-09 11:44:44.850+0200 W/APPS    ( 1088): AppsItem.cpp: aniFocusIndex(2373) >  [watchapp:14] Focused[0], focusIdx[14]
09-09 11:44:44.850+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
09-09 11:44:45.070+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: onAutoLaunchTimerStart(5026) >  auto launch is disabled
09-09 11:44:47.975+0200 E/EFL     ( 1088): ecore_x<1088> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=2402486 button=1
09-09 11:44:47.975+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 11:44:47.975+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 11:44:47.975+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: touchPressed(1663) >  TOUCH [175, 199]
09-09 11:44:47.975+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: onBubbleButtonEffect(2428) >  [249, 249, 249, 102]
09-09 11:44:47.975+0200 E/EFL     ( 1088): evas_main<1088> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
09-09 11:44:47.975+0200 E/EFL     ( 1088): evas_main<1088> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
09-09 11:44:47.975+0200 E/EFL     ( 1088): evas_main<1088> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
09-09 11:44:47.975+0200 E/W_HOME  ( 1088): util.c: util_is_rdu_retailmode(1530) > Cannot get the vconf for retailmode
09-09 11:44:48.025+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 11:44:48.035+0200 E/EFL     ( 1088): ecore_x<1088> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=2402551 button=1
09-09 11:44:48.035+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: touchReleased(1976) >  TOUCH [175, 199]->[176, 199]
09-09 11:44:48.035+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: onBubbleButtonEffect(2446) >  [249, 249, 249, 255]
09-09 11:44:48.035+0200 W/APPS    ( 1088): AppsItem.cpp: onItemClicked(478) >  onItemClicked[0,14]
09-09 11:44:48.035+0200 E/APPS    ( 1088): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
09-09 11:44:48.035+0200 W/APPS    ( 1088): AppsItem.cpp: onItemClicked(502) >  item(watchapp) launched, open(0), tts(0)
09-09 11:44:48.035+0200 W/AUL     ( 1088): launch.c: app_request_to_launchpad(284) > request cmd(0) to(co.za.littlekidogo.watchapp)
09-09 11:44:48.040+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 0
09-09 11:44:48.045+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(1782) > caller pid : 1088
09-09 11:44:48.045+0200 I/AUL_AMD (  509): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
09-09 11:44:48.055+0200 E/RESOURCED(  681): block.c: block_prelaunch_state(138) > insert data co.za.littlekidogo.watchapp, table num : 2
09-09 11:44:48.060+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(2218) > pad pid(-5)
09-09 11:44:48.060+0200 W/AUL_PAD ( 1235): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
09-09 11:44:48.060+0200 W/AUL_PAD ( 1235): launchpad.c: __send_result_to_caller(272) > Check app launching
09-09 11:44:48.060+0200 W/AUL_PAD ( 3977): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
09-09 11:44:48.060+0200 W/AUL_PAD ( 3977): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
09-09 11:44:48.060+0200 W/AUL_PAD ( 3977): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
09-09 11:44:48.060+0200 W/AUL_PAD ( 3977): launchpad_loader.c: main(680) > [candidate] dlopen(co.za.littlekidogo.watchapp)
09-09 11:44:48.100+0200 I/efl-extension( 3977): efl_extension.c: eext_mod_init(40) > Init
09-09 11:44:48.105+0200 I/UXT     ( 3977): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
09-09 11:44:48.105+0200 W/AUL_PAD ( 3977): launchpad_loader.c: main(690) > [candidate] dlsym
09-09 11:44:48.105+0200 W/AUL_PAD ( 3977): launchpad_loader.c: main(694) > [candidate] dl_main(co.za.littlekidogo.watchapp)
09-09 11:44:48.105+0200 I/CAPI_APPFW_APPLICATION( 3977): app_main.c: ui_app_main(704) > app_efl_main
09-09 11:44:48.105+0200 I/CAPI_APPFW_APPLICATION( 3977): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
09-09 11:44:48.160+0200 W/AUL     (  509): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(co.za.littlekidogo.watchapp) pid(3977) type(uiapp) bg(0)
09-09 11:44:48.160+0200 W/AUL_AMD (  509): amd_status.c: __socket_monitor_cb(1277) > (3977) was created
09-09 11:44:48.160+0200 E/AUL     (  509): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
09-09 11:44:48.160+0200 W/AUL     ( 1088): launch.c: app_request_to_launchpad(298) > request cmd(0) result(3977)
09-09 11:44:48.160+0200 W/STARTER (  964): pkg-monitor.c: _app_mgr_status_cb(400) > [_app_mgr_status_cb:400] Launch request [3977]
09-09 11:44:48.160+0200 W/W_HOME  ( 1088): util.c: apps_util_launch_main_operation(785) > Launch app:[watchapp] ret:[0]
09-09 11:44:48.170+0200 W/W_HOME  ( 1088): util.c: send_launch_appId(620) > launch appid[co.za.littlekidogo.watchapp]
09-09 11:44:48.170+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 11:44:48.170+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 11:44:48.170+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 11:44:48.170+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 11:44:48.170+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-09 11:44:48.170+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 11:44:48.170+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.app-shortcut-widget:Apptray.Message.Launch.AppId]
09-09 11:44:48.170+0200 E/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
09-09 11:44:48.170+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 11:44:48.170+0200 E/MESSAGE_PORT( 1088): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (Apptray.Message.Launch.AppId) is not found.
09-09 11:44:48.170+0200 E/W_HOME  ( 1088): util.c: send_launch_appId(636) > There is no remote message port
09-09 11:44:48.170+0200 W/APPS    ( 1088): AppsItem.cpp: onItemClicked(536) >  appid(co.za.littlekidogo.watchapp)  pkgid(co.za.littlekidogo.watchapp), name(watchapp)
09-09 11:44:48.235+0200 E/EFL     ( 3977): ecore_evas<3977> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
09-09 11:44:48.445+0200 W/CRASH_MANAGER( 3781): worker.c: worker_job(1205) > 11039777761741536486288
09-09 11:44:49.045+0200 E/EFL     (  404): ecore_x<404> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x3600003 time=2402751
09-09 11:44:49.045+0200 E/EFL     ( 1088): ecore_x<1088> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=2402751
09-09 11:44:49.045+0200 E/EFL     (  404): ecore_x<404> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=2402751
09-09 11:44:49.210+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 3977 pgid = 3977
09-09 11:44:49.210+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
09-09 11:44:49.220+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __read_proc(55) > file open error : 2
09-09 11:44:49.220+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
09-09 11:44:49.220+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(3977), proc(0)
09-09 11:44:49.220+0200 E/AUL     ( 1272): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
09-09 11:44:49.220+0200 E/CAPI_APPFW_APP_MANAGER( 1272): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
09-09 11:44:49.220+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
09-09 11:44:49.260+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
09-09 11:44:49.260+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __read_proc(55) > file open error : 2
09-09 11:44:49.260+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
09-09 11:44:49.260+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(3977), proc(0)
09-09 11:44:49.260+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
09-09 11:44:49.260+0200 I/AUL_AMD (  509): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 3977
09-09 11:44:49.260+0200 W/AUL     (  509): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(3977)
09-09 11:44:49.265+0200 E/AUL     ( 1374): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
09-09 11:44:49.265+0200 E/CAPI_APPFW_APP_MANAGER( 1374): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
09-09 11:44:50.715+0200 E/EFL     ( 1088): ecore_x<1088> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=2405229 button=1
09-09 11:44:50.715+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 11:44:50.715+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 11:44:50.715+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: touchPressed(1663) >  TOUCH [129, 206]
09-09 11:44:50.715+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: onBubbleButtonEffect(2428) >  [249, 249, 249, 102]
09-09 11:44:50.715+0200 E/EFL     ( 1088): evas_main<1088> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
09-09 11:44:50.715+0200 E/EFL     ( 1088): evas_main<1088> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
09-09 11:44:50.715+0200 E/EFL     ( 1088): evas_main<1088> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
09-09 11:44:50.720+0200 E/W_HOME  ( 1088): util.c: util_is_rdu_retailmode(1530) > Cannot get the vconf for retailmode
09-09 11:44:50.755+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 11:44:50.765+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 11:44:50.780+0200 E/EFL     ( 1088): ecore_x<1088> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=2405293 button=1
09-09 11:44:50.780+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: touchReleased(1976) >  TOUCH [129, 206]->[131, 202]
09-09 11:44:50.780+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: onBubbleButtonEffect(2446) >  [249, 249, 249, 255]
09-09 11:44:50.780+0200 W/APPS    ( 1088): AppsItem.cpp: onItemClicked(478) >  onItemClicked[0,14]
09-09 11:44:50.780+0200 E/APPS    ( 1088): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
09-09 11:44:50.780+0200 W/APPS    ( 1088): AppsItem.cpp: onItemClicked(502) >  item(watchapp) launched, open(0), tts(0)
09-09 11:44:50.785+0200 W/AUL     ( 1088): launch.c: app_request_to_launchpad(284) > request cmd(0) to(co.za.littlekidogo.watchapp)
09-09 11:44:50.785+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 0
09-09 11:44:50.785+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(1782) > caller pid : 1088
09-09 11:44:50.785+0200 I/AUL_AMD (  509): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
09-09 11:44:50.795+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(2218) > pad pid(-5)
09-09 11:44:50.795+0200 W/AUL_PAD ( 1235): launchpad.c: __launchpad_main_loop(630) > Candidate is not prepared, enter legacy logic
09-09 11:44:50.795+0200 W/AUL_PAD ( 1235): launchpad.c: __send_result_to_caller(272) > Check app launching
09-09 11:44:50.795+0200 E/AUL_PAD ( 1235): launchpad.c: __send_result_to_caller(278) > launching failed
09-09 11:44:50.795+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(2229) > Launch with legacy way : no launchpad
09-09 11:44:50.800+0200 W/AUL_AMD (  509): amd_launch.c: start_process(606) > child process: 4029
09-09 11:44:50.800+0200 E/RESOURCED(  681): block.c: block_prelaunch_state(138) > insert data co.za.littlekidogo.watchapp, table num : 2
09-09 11:44:50.850+0200 W/AUL_AMD (  509): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 4029
09-09 11:44:50.850+0200 W/AUL     (  509): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(co.za.littlekidogo.watchapp) pid(4029) type(uiapp) bg(0)
09-09 11:44:50.850+0200 E/AUL     (  509): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
09-09 11:44:50.855+0200 W/AUL     ( 1088): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4029)
09-09 11:44:50.855+0200 W/W_HOME  ( 1088): util.c: apps_util_launch_main_operation(785) > Launch app:[watchapp] ret:[0]
09-09 11:44:50.860+0200 W/STARTER (  964): pkg-monitor.c: _app_mgr_status_cb(400) > [_app_mgr_status_cb:400] Launch request [4029]
09-09 11:44:50.865+0200 W/W_HOME  ( 1088): util.c: send_launch_appId(620) > launch appid[co.za.littlekidogo.watchapp]
09-09 11:44:50.865+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 11:44:50.865+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 11:44:50.865+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 11:44:50.865+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 11:44:50.865+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-09 11:44:50.865+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 11:44:50.865+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.app-shortcut-widget:Apptray.Message.Launch.AppId]
09-09 11:44:50.865+0200 E/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
09-09 11:44:50.865+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 11:44:50.865+0200 E/MESSAGE_PORT( 1088): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (Apptray.Message.Launch.AppId) is not found.
09-09 11:44:50.865+0200 E/W_HOME  ( 1088): util.c: send_launch_appId(636) > There is no remote message port
09-09 11:44:50.865+0200 W/APPS    ( 1088): AppsItem.cpp: onItemClicked(536) >  appid(co.za.littlekidogo.watchapp)  pkgid(co.za.littlekidogo.watchapp), name(watchapp)
09-09 11:44:50.905+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 14
09-09 11:44:50.915+0200 W/AUL_AMD (  509): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4029
09-09 11:44:50.915+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 12
09-09 11:44:50.975+0200 I/efl-extension( 4029): efl_extension.c: eext_mod_init(40) > Init
09-09 11:44:51.005+0200 I/CAPI_APPFW_APPLICATION( 4029): app_main.c: ui_app_main(704) > app_efl_main
09-09 11:44:51.085+0200 I/UXT     ( 4029): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
09-09 11:44:51.240+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 14
09-09 11:44:51.245+0200 W/AUL_AMD (  509): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4029
09-09 11:44:51.265+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 12
09-09 11:44:51.295+0200 W/AUL_AMD (  509): amd_status.c: __socket_monitor_cb(1277) > (4029) was created
09-09 11:44:51.300+0200 I/CAPI_APPFW_APPLICATION( 4029): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
09-09 11:44:51.365+0200 E/MALI    ( 4029): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
09-09 11:44:51.365+0200 E/MALI    ( 4029): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
09-09 11:44:51.365+0200 E/MALI    ( 4029): [gpu-ddk] devel/graphics_drv/r4p0
09-09 11:44:51.365+0200 E/MALI    ( 4029): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
09-09 11:44:51.365+0200 E/MALI    ( 4029): [coregl] devel/graphics_engine/master
09-09 11:44:51.365+0200 E/MALI    ( 4029): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
09-09 11:44:51.530+0200 E/EFL     ( 4029): ecore_evas<4029> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
09-09 11:44:51.535+0200 W/W_INDICATOR( 1003): windicator_connection.c: _wifi_state_changed_cb(930) > [_wifi_state_changed_cb:930] wifi state : 2
09-09 11:44:51.535+0200 W/W_INDICATOR( 1003): windicator_connection.c: _wifi_state_changed_cb(974) > [_wifi_state_changed_cb:974] ap_name : (squirrel2GHZ)
09-09 11:44:51.535+0200 W/W_INDICATOR( 1003): windicator_connection.c: _wifi_state_changed_cb(994) > [_wifi_state_changed_cb:994] wifi strength : 3
09-09 11:44:51.535+0200 W/W_INDICATOR( 1003): windicator_connection.c: _connection_icon_set(713) > [_connection_icon_set:713] type : 15 / signal : type_wifi_connected_03
09-09 11:44:51.535+0200 E/W_INDICATOR( 1003): windicator_connection.c: _connection_icon_set(754) > [_connection_icon_set:754] Set Connection / show sw.icon_1 (15)(0)
09-09 11:44:51.535+0200 W/W_INDICATOR( 1003): windicator_connection.c: _packet_type_changed_cb(1251) > [_packet_type_changed_cb:1251] _packet_type_changed_cb
09-09 11:44:51.535+0200 E/W_INDICATOR( 1003): windicator_connection.c: _packet_type_changed_cb(1261) > [_packet_type_changed_cb:1261] WIFI MODE
09-09 11:44:51.535+0200 W/W_INDICATOR( 1003): windicator_connection.c: _packet_icon_set(840) > [_packet_icon_set:840] packet : 3 / signal : packet_inout_connected
09-09 11:44:51.700+0200 W/CRASH_MANAGER( 3781): worker.c: worker_job(1205) > 1104029776174153648629
