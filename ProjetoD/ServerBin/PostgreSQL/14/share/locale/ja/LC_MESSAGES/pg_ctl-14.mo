??    ?        ?   
      ?      ?     ?  &   ?     ?          2     I     _  /   r     ?  "   ?  1   ?  ?     "   ?  j   ?  o   A     ?  D   ?  !     3   6  ?   j  H   ?  D   ?  C   8  E   |  ?   ?  ?     >   B  9   ?  L   ?  B     E   K  ?   ?  0     F   G  >   ?  B   ?  I     %   Z  <   ?  O   ?  7        E     L     U     g  M   {     ?  -   ?  !     >   )  E   h  C   ?  y   ?  9   l  D   ?  C   ?  D   /  E   t  >   ?  A   ?  '   ;  (   c  ,   ?  7   ?  2   ?  6   $  >   [  *   ?  /   ?  7   ?  4   -  %   b  %   ?  1   ?  0   ?  #        5  4   S  7   ?  2   ?  6   ?  1   *  0   \  ,   ?  .   ?  3   ?  7         U   +   u   1   ?   6   ?   6   
!  1   A!  *   s!  "   ?!  7   ?!  "   ?!  $   "  J   A"     ?"     ?"  3   ?"  0   ?"     $#  #   7#  !   [#     }#  !   ?#  $   ?#      ?#  -   $     2$  4   R$  %   ?$  $   ?$  "   ?$  !   ?$  u   %  F   ?%     ?%  7   ?%  )    &  k   J&  `   ?&  %   '  &   ='     d'  d   l'     ?'  /   ?'  &    (  0   G(  .   x(  -   ?(     ?(     ?(  &   ?(      %)  ,   F)  (   s)     ?)  %   ?)     ?)     ?)     ?)     *     *     1*     G*  #   X*     |*     ?*     ?*     ?*     ?*      ?*  "   +     (+  ?  G+  1   %-     W-  *   s-  &   ?-  &   ?-  -   ?-  3   .  $   N.  /   s.     ?.  "   ?.  1   ?.  ?   /  "   ?/  j   ?/  o   B0     ?0  D   ?0  !   1  >   71  A   v1  M   ?1  b   2  Y   i2  S   ?2  D   3  8   \3  F   ?3  P   ?3  e   -4  ]   ?4  N   ?4  ?   @5  )   ?5  k   6  R   z6  M   ?6  [   7  5   w7  D   ?7  b   ?7  ?   U8     ?8     ?8  &   ?8     ?8  j   ?8     `9  [   9  *   ?9  a   :  p   h:  u   ?:  ?   O;  g   ?;  k   g<  r   ?<  r   F=  o   ?=  r   )>  u   ?>  5   ?  F   H?  G   ??  d   ??  U   <@  V   ?@  `   ?@  A   JA  ;   ?A  D   ?A  P   B  C   ^B  F   ?B  \   ?B  Q   FC  D   ?C  ?   ?C  K   D  X   iD  C   ?D  V   E  G   ]E  O   ?E  B   ?E  I   8F  `   ?F  S   ?F  6   7G  G   nG  K   ?G  Q   H  d   TH  U   ?H  D   I  0   TI  c   ?I  ?   ?I  0   )J  S   ZJ  2   ?J  ,   ?J  Q   K  O   `K     ?K  ;   ?K  ;   L  ,   =L  -   jL  ,   ?L  3   ?L  E   ?L  $   ?M  B   dM  '   ?M  0   ?M  !    N  !   "N  ?   DN  K   ?N  )   +O  ^   UO  =   ?O  ?   ?O  ?   ?P  =   aQ  3   ?Q     ?Q  ?   ?Q  4   ?R  ;   ?R  8   ?R  J   ,S  1   wS  ?   ?S  6   ?S  $    T  ;   ET  4   ?T  G   ?T  C   ?T  1   BU  >   tU     ?U     ?U     ?U  "   ?U     V     1V  1   QV  C   ?V     ?V  "   ?V  "   W  1   'W  1   YW  -   ?W  9   ?W  3   ?W     a   2   *   B       ?   ,   U   ?   )   7       M   ?       ;   L   <       R      W          &   b   G   8   4          }   ?           -      6      ?       O       ?      ~   T               1   K   h   ?   ?              ?   P      {       X          0       ?       ?          ?   !   :   w   |   ?   z       #   ?      p   +       t       V      e           9   N               d       ?   @   D   ?      ?   i   c   %      "   ?              r       _   f   s   ?   .       ?       E   ?       /      ]   `      Q   >               Z   ?   
           (       v   ?           \   m   $   k   ?   l       g          A   ?              =           x       J       n       ?       ?   '   ^   [          ?       H   q   ?   o   ?   C          y       Y       S      ?   ?                	   j   ?                     u   F   I          ?   3          5    
Allowed signal names for kill:
 
Common options:
 
Options for register and unregister:
 
Options for start or restart:
 
Options for stop or restart:
 
Report bugs to <%s>.
 
Shutdown modes are:
 
Start types are:
   %s init[db]   [-D DATADIR] [-s] [-o OPTIONS]
   %s kill       SIGNALNAME PID
   %s logrotate  [-D DATADIR] [-s]
   %s promote    [-D DATADIR] [-W] [-t SECS] [-s]
   %s register   [-D DATADIR] [-N SERVICENAME] [-U USERNAME] [-P PASSWORD]
                    [-S START-TYPE] [-e SOURCE] [-W] [-t SECS] [-s] [-o OPTIONS]
   %s reload     [-D DATADIR] [-s]
   %s restart    [-D DATADIR] [-m SHUTDOWN-MODE] [-W] [-t SECS] [-s]
                    [-o OPTIONS] [-c]
   %s start      [-D DATADIR] [-l FILENAME] [-W] [-t SECS] [-s]
                    [-o OPTIONS] [-p PATH] [-c]
   %s status     [-D DATADIR]
   %s stop       [-D DATADIR] [-m SHUTDOWN-MODE] [-W] [-t SECS] [-s]
   %s unregister [-N SERVICENAME]
   -?, --help             show this help, then exit
   -D, --pgdata=DATADIR   location of the database storage area
   -N SERVICENAME  service name with which to register PostgreSQL server
   -P PASSWORD     password of account to register PostgreSQL server
   -S START-TYPE   service start type to register PostgreSQL server
   -U USERNAME     user name of account to register PostgreSQL server
   -V, --version          output version information, then exit
   -W, --no-wait          do not wait until operation completes
   -c, --core-files       allow postgres to produce core files
   -c, --core-files       not applicable on this platform
   -e SOURCE              event source for logging when running as a service
   -l, --log=FILENAME     write (or append) server log to FILENAME
   -m, --mode=MODE        MODE can be "smart", "fast", or "immediate"
   -o, --options=OPTIONS  command line options to pass to postgres
                         (PostgreSQL server executable) or initdb
   -p PATH-TO-POSTGRES    normally not necessary
   -s, --silent           only print errors, no informational messages
   -t, --timeout=SECS     seconds to wait when using -w option
   -w, --wait             wait until operation completes (default)
   auto       start service automatically during system startup (default)
   demand     start service on demand
   fast        quit directly, with proper shutdown (default)
   immediate   quit without complete shutdown; will lead to recovery on restart
   smart       quit after all clients have disconnected
  done
  failed
  stopped waiting
 %s home page: <%s>
 %s is a utility to initialize, start, stop, or control a PostgreSQL server.

 %s() failed: %m %s: -S option not supported on this platform
 %s: PID file "%s" does not exist
 %s: WARNING: cannot create restricted tokens on this platform
 %s: WARNING: could not locate all job object functions in system API
 %s: another server might be running; trying to start server anyway
 %s: cannot be run as root
Please log in (using, e.g., "su") as the (unprivileged) user that will
own the server process.
 %s: cannot promote server; server is not in standby mode
 %s: cannot promote server; single-user server is running (PID: %ld)
 %s: cannot reload server; single-user server is running (PID: %ld)
 %s: cannot restart server; single-user server is running (PID: %ld)
 %s: cannot rotate log file; single-user server is running (PID: %ld)
 %s: cannot set core file size limit; disallowed by hard limit
 %s: cannot stop server; single-user server is running (PID: %ld)
 %s: control file appears to be corrupt
 %s: could not access directory "%s": %s
 %s: could not allocate SIDs: error code %lu
 %s: could not create log rotation signal file "%s": %s
 %s: could not create promote signal file "%s": %s
 %s: could not create restricted token: error code %lu
 %s: could not determine the data directory using command "%s"
 %s: could not find own program executable
 %s: could not find postgres program executable
 %s: could not get LUIDs for privileges: error code %lu
 %s: could not get token information: error code %lu
 %s: could not open PID file "%s": %s
 %s: could not open log file "%s": %s
 %s: could not open process token: error code %lu
 %s: could not open service "%s": error code %lu
 %s: could not open service manager
 %s: could not read file "%s"
 %s: could not register service "%s": error code %lu
 %s: could not remove log rotation signal file "%s": %s
 %s: could not remove promote signal file "%s": %s
 %s: could not send log rotation signal (PID: %ld): %s
 %s: could not send promote signal (PID: %ld): %s
 %s: could not send reload signal (PID: %ld): %s
 %s: could not send signal %d (PID: %ld): %s
 %s: could not send stop signal (PID: %ld): %s
 %s: could not start server
Examine the log output.
 %s: could not start server due to setsid() failure: %s
 %s: could not start server: %s
 %s: could not start server: error code %lu
 %s: could not start service "%s": error code %lu
 %s: could not unregister service "%s": error code %lu
 %s: could not write log rotation signal file "%s": %s
 %s: could not write promote signal file "%s": %s
 %s: database system initialization failed
 %s: directory "%s" does not exist
 %s: directory "%s" is not a database cluster directory
 %s: invalid data in PID file "%s"
 %s: missing arguments for kill mode
 %s: no database directory specified and environment variable PGDATA unset
 %s: no operation specified
 %s: no server running
 %s: old server process (PID: %ld) seems to be gone
 %s: option file "%s" must have exactly one line
 %s: out of memory
 %s: server did not promote in time
 %s: server did not start in time
 %s: server does not shut down
 %s: server is running (PID: %ld)
 %s: service "%s" already registered
 %s: service "%s" not registered
 %s: single-user server is running (PID: %ld)
 %s: the PID file "%s" is empty
 %s: too many command-line arguments (first is "%s")
 %s: unrecognized operation mode "%s"
 %s: unrecognized shutdown mode "%s"
 %s: unrecognized signal name "%s"
 %s: unrecognized start type "%s"
 HINT: The "-m fast" option immediately disconnects sessions rather than
waiting for session-initiated disconnection.
 If the -D option is omitted, the environment variable PGDATA is used.
 Is server running?
 Please terminate the single-user server and try again.
 Server started and accepting connections
 The program "%s" is needed by %s but was not found in the
same directory as "%s".
Check your installation.
 The program "%s" was found by "%s"
but was not the same version as %s.
Check your installation.
 Timed out waiting for server startup
 Try "%s --help" for more information.
 Usage:
 WARNING: online backup mode is active
Shutdown will not complete until pg_stop_backup() is called.

 Waiting for server startup...
 cannot duplicate null pointer (internal error)
 child process exited with exit code %d child process exited with unrecognized status %d child process was terminated by exception 0x%X child process was terminated by signal %d: %s command not executable command not found could not change directory to "%s": %m could not find a "%s" to execute could not get current working directory: %s
 could not identify current directory: %m could not read binary "%s" could not read symbolic link "%s": %m invalid binary "%s" out of memory out of memory
 server promoted
 server promoting
 server shutting down
 server signaled
 server signaled to rotate log file
 server started
 server starting
 server stopped
 starting server anyway
 trying to start server anyway
 waiting for server to promote... waiting for server to shut down... waiting for server to start... Project-Id-Version: pg_ctl (PostgreSQL 14)
Report-Msgid-Bugs-To: pgsql-bugs@lists.postgresql.org
POT-Creation-Date: 2021-08-25 17:21+0900
PO-Revision-Date: 2021-08-19 17:35+0900
Last-Translator: Kyotaro Horiguchi <horikyota.ntt@gmail.com>
Language-Team: Japan PostgreSQL Users Group <jpug-doc@ml.postgresql.jp>
Language: ja
MIME-Version: 1.0
Content-Type: text/plain; charset=UTF-8
Content-Transfer-Encoding: 8bit
Plural-Forms: nplurals=1; plural=0;
X-Generator: Poedit 1.8.13
 
killモードで利用できるシグナル名:
 
共通のオプション:
 
登録、登録解除のオプション:
 
起動、再起動のオプション
 
停止、再起動のオプション
 
バグは<%s>に報告してください。
 
シャットダウンモードは以下の通り:
 
起動タイプは以下の通り:
   %s init[db]   [-D DATADIR] [-s] [-o OPTIONS]
   %s kill       SIGNALNAME PID
   %s logrotate  [-D DATADIR] [-s]
   %s promote    [-D DATADIR] [-W] [-t SECS] [-s]
   %s register   [-D DATADIR] [-N SERVICENAME] [-U USERNAME] [-P PASSWORD]
                    [-S START-TYPE] [-e SOURCE] [-W] [-t SECS] [-s] [-o OPTIONS]
   %s reload     [-D DATADIR] [-s]
   %s restart    [-D DATADIR] [-m SHUTDOWN-MODE] [-W] [-t SECS] [-s]
                    [-o OPTIONS] [-c]
   %s start      [-D DATADIR] [-l FILENAME] [-W] [-t SECS] [-s]
                    [-o OPTIONS] [-p PATH] [-c]
   %s status     [-D DATADIR]
   %s stop       [-D DATADIR] [-m SHUTDOWN-MODE] [-W] [-t SECS] [-s]
   %s unregister [-N SERVICENAME]
   -?, --help             このヘルプを表示して終了
   -D, --pgdata=DATADIR   データベース格納領域の場所
   -N SERVICENAME  PostgreSQLサーバーを登録する際のサービス名
   -P PASSWORD     PostgreSQLサーバーを登録するためのアカウントのパスワード
   -S START-TYPE   PostgreSQLサーバーを登録する際のサービス起動タイプ
   -U USERNAME     PostgreSQLサーバーを登録するためのアカウント名
   -V, --version          バージョン情報を表示して終了
   -W, --no-wait          作業の完了を待たない
   -c, --core-files       postgresのコアファイル生成を許可
   -c, --core-files       このプラットフォームでは適用されない
   -e SOURCE              サービスとして起動させたときのログのイベントソース
   -l, --log FILENAME     サーバーログをFILENAMEへ書き込む(または追加する)
   -m, --mode=MODE        MODEは"smart"、"fast"、"immediate"のいずれか
   -o, --options=OPTIONS  postgres(PostgreSQLサーバー実行ファイル)または
                         initdb に渡すコマンドラインオプション
   -p PATH-TO-POSTGRES    通常は不要
   -s, --silent           エラーメッセージのみを表示、情報メッセージは表示しない
   -t, --timeout=SECS     -wオプションを使用する時に待機する秒数
   -w, --wait             操作が完了するまで待機 (デフォルト)
   auto       システムの起動時にサービスを自動的に開始(デフォルト)
   demand     要求に応じてサービスを開始
   fast        適切な手続きで直ちに停止(デフォルト)
   immediate   適切な手続き抜きで停止; 再起動時にはリカバリが実行される
   smart       全クライアントの接続切断後に停止
 完了
 失敗しました
  待機処理が停止されました
 %s ホームページ: <%s>
 %sはPostgreSQLサーバーの初期化、起動、停止、制御を行うユーティリティです。
 %s() が失敗しました: %m %s: -Sオプションはこのプラットフォームでサポートされていません
 %s: PIDファイル"%s"がありません
 %s: 警告: このプラットフォームでは制限付きトークンを作成できません
 %s: 警告: システムAPI内にすべてのジョブオブジェクト関数を格納できませんでした
 %s: 他のサーバーが動作中の可能性がありますが、とにかくpostmasterの起動を試みます。
 %s: rootでは実行できません
サーバープロセスの所有者となる(非特権)ユーザーとして("su"などを使用して)
ログインしてください。
 %s: サーバーを昇格できません; サーバーはスタンバイモードではありません
 %s: サーバーを昇格できません; シングルユーザーサーバー(PID: %ld)が動作中です
 %s: サーバーをリロードできません。シングルユーザーサーバー(PID: %ld)が動作中です
 %s: サーバーを再起動できません。シングルユーザーサーバー(PID: %ld)が動作中です。
 %s: ログをローテートできません; シングルユーザーサーバーが動作中です (PID: %ld)
 %s: コアファイルのサイズ制限を設定できません:固定の制限により許されていません
 %s: サーバーを停止できません。シングルユーザーサーバー(PID: %ld)が動作しています。
 %s: 制御ファイルが壊れているようです
 %s: ディレクトリ"%s"にアクセスできませんでした: %s
 %s: SIDを割り当てられませんでした: エラーコード %lu
 %s: ログローテート指示ファイル"%s"を作成することができませんでした: %s
 %s: 昇格指示ファイル"%s"を作成することができませんでした: %s
 %s: 制限付きトークンを作成できませんでした: エラーコード %lu
 %s: コマンド"%s"を使用するデータディレクトリを決定できませんでした
 %s: 自身の実行ファイルが見つかりませんでした
 %s: postgres の実行ファイルが見つかりません
 %s: 権限の LUID を取得できません: エラーコード %lu
 %s: トークン情報を取得できませんでした: エラーコード %lu
 %s: PIDファイル"%s"をオープンできませんでした: %s
 %s: ログファイル"%s"をオープンできませんでした: %s
 %s: プロセストークンをオープンできませんでした: エラーコード %lu
 %s: サービス"%s"のオープンに失敗しました: エラーコード %lu
 %s: サービスマネージャのオープンに失敗しました
 %s: ファイル"%s"を読み取ることに失敗しました
 %s: サービス"%s"の登録に失敗しました: エラーコード %lu
 %s: ログローテーション指示ファイル"%s"の削除に失敗しました: %s
 %s: 昇格指示ファイル"%s"の削除に失敗しました: %s
 %s: ログローテートシグナルを送信できませんでした (PID: %ld): %s
 %s: 昇格シグナルを送信できませんでした (PID: %ld): %s
 %s: リロードシグナルを送信できませんでした。(PID: %ld): %s
 %s: シグナル%dを送信できませんでした(PID: %ld): %s
 %s: 停止シグナルを送信できませんでした。(PID: %ld): %s
 %s: サーバーを起動できませんでした。
ログ出力を確認してください。
 %s: setsid()に失敗したためサーバーに接続できませんでした: %s
 %s: サーバーに接続できませんでした: %s
 %s: サーバーの起動に失敗しました: エラーコード %lu
 %s: サービス"%s"の起動に失敗しました: エラーコード %lu
 %s: サービス"%s"の登録削除に失敗しました: エラーコード %lu
 %s: ログローテート指示ファイル"%s"に書き出すことができませんでした: %s
 %s: 昇格指示ファイル"%s"に書き出すことができませんでした: %s
 %s: データベースシステムが初期化に失敗しました
 %s: ディレクトリ"%s"は存在しません
 %s: ディレクトリ"%s"はデータベースクラスタディレクトリではありません
 %s: PIDファイル"%s"内に無効なデータがあります
 %s: killモード用の引数がありません
 %s: データベースの指定も、PGDATA環境変数の設定もありません
 %s: 操作モードが指定されていません
 %s: サーバーが動作していません
 %s: 古いサーバープロセス(PID: %ld)が動作していないようです
 %s: オプションファイル"%s"は1行のみでなければなりません
 %s: メモリ不足
 %s: サーバーは時間内に昇格しませんでした
 %s: サーバーは時間内に停止しませんでした
 %s: サーバーは停止していません
 %s: サーバーが動作中です(PID: %ld)
 %s: サービス\"%s\"は登録済みです
 %s: サービス"%s"は登録されていません
 %s: シングルユーザーサーバーが動作中です(PID: %ld)
 %s: PIDファイル"%s"が空です
 %s: コマンドライン引数が多すぎます (先頭は"%s")
 %s: 操作モード"%s"は不明です
 %s: 不正なシャットダウンモード"%s"
 %s: 不正なシグナル名"%s"
 %s: 不正な起動タイプ"%s"
 ヒント: "-m fast"オプションは、セッション切断が始まるまで待機するのではなく
即座にセッションを切断します。
 -Dオプションの省略時はPGDATA環境変数が使用されます。
 サーバーが動作していますか?
 シングルユーザーサーバーを終了させてから、再度実行してください
 サーバーは起動し、接続を受け付けています
 %2$sにはプログラム"%1$s"が必要ですが、"%3$s"と同じディレクトリ
にはありませんでした。
インストールの状態を確認してください。
 "%2$s"がプログラム"%1$s"を見つけましたが、これは%3$sと同じ
バージョンではありませんでした。
インストールの状態を確認してください。
 サーバーの起動待機がタイムアウトしました
 詳細は"%s --help"で確認してください。
 使用方法:
 警告: オンラインバックアップモードが実行中です。
pg_stop_backup()が呼び出されるまでシャットダウンは完了しません

 サーバーの起動完了を待っています...
 nullポインタは複製できません (内部エラー)
 子プロセスが終了コード%dで終了しました 子プロセスは認識できないステータス%dで終了しました 子プロセスが例外0x%Xで終了しました 子プロセスはシグナル%dにより終了しました: %s コマンドは実行可能形式ではありません コマンドが見つかりません ディレクトリ"%s"に移動できませんでした: %m 実行対象の"%s"が見つかりませんでした 現在の作業ディレクトリを取得できませんでした: %s
 カレントディレクトリを確認できませんでした: %m バイナリ"%s"を読み取れませんでした シンボリックリンク"%s"を読めませんでした: %m 不正なバイナリ"%s" メモリ不足 メモリ不足
 サーバーは昇格しました
 サーバーを昇格中です
 サーバーの停止中です
 サーバーにシグナルを送信しました
 サーバーがログローテートをシグナルされました
 サーバー起動完了
 サーバーは起動中です。
 サーバーは停止しました
 とにかくサーバーを起動しています
 とにかくサーバーの起動を試みます
 サーバーの昇格を待っています... サーバー停止処理の完了を待っています... サーバーの起動完了を待っています... 