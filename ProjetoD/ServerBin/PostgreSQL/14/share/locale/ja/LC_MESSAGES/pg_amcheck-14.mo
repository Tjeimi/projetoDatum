??    ^           ?      ?      ?          0     A     X     r  S   ?  H   ?  V   !	  =   x	  A   ?	  U   ?	  Z   N
  K   ?
  M   ?
  I   C  I   ?  T   ?  T   ,     ?  <   ?  D   ?  B     <   a  D   ?  B   ?  A   &  :   h  H   ?  8   ?  6   %  =   \  M   ?  K   ?  ;   4  U   p  7   ?  =   ?  ;   <  :   x  8   ?  <   ?  ,   )  0   V  7   ?     ?  <   ?     ?  +        ?     T  &   t     ?     ?  V   ?  )     9   =     w     ?     ?  /   ?     ?             *   ?     j     r  :   z  ,   ?  !   ?       ;        X  :   p  :   ?     ?            '   +  /   S     ?  %   ?     ?  .   ?  #     *   (     S     d     r  0   ?     ?  /   ?  	   ?  Z    0   a     ?     ?  -   ?  $   ?       ?   <  ^   ?  ?   -  V   ?  D   %  ?   j  ?     ?   ?  S   :  S   ?  Y   ?  ?   <   ?   ?   2   d!  G   ?!  Y   ?!  Y   9"  >   ?"  Y   ?"  S   ,#  S   ?#  D   ?#  M   $  G   g$  P   ?$  P    %  S   Q%  ?   ?%  P   =&  S   ?&  M   ?&  P   0'  J   ?'  J   ?'  M   (  D   e(  ;   ?(  ?   ?(  G   &)     n)  _   q)     ?)  7   ?)  +   &*  8   R*  3   ?*     ?*  .   ?*  h   ?*  N   f+  W   ?+  -   ,  +   ;,     g,  F   x,     ?,     ?,  <   ?,  A   6-     x-     ?-  Q   ?-  F   ?-  =   2.  ,   p.  R   ?.  %   ?.  W   /  W   n/  )   ?/     ?/     0  K   (0  W   t0  3   ?0  I    1  3   J1  U   ~1  F   ?1  I   2  (   e2     ?2     ?2  a   ?2     3  =   83     v3        *                 .   R   >      +             	       O       J                [      N   (   /   8   ,       $         )          I   -   A      7   3   G      D       
                W   C       Y       M          T   9         \   E              Q   0   '   @   &          !       P       ^   5          S   K           L   <      %          X   4       "   F              ?   Z   :   H   B       #           6       ]   2               U       ;   =   1          V    
B-tree index checking options:
 
Connection options:
 
Other options:
 
Report bugs to <%s>.
 
Table checking options:
 
Target options:
       --endblock=BLOCK            check table(s) only up to the given block number
       --exclude-toast-pointers    do NOT follow relation TOAST pointers
       --heapallindexed            check that all heap tuples are found within indexes
       --install-missing           install missing extensions
       --maintenance-db=DBNAME     alternate maintenance database
       --no-dependent-indexes      do NOT expand list of relations to include indexes
       --no-dependent-toast        do NOT expand list of relations to include TOAST tables
       --no-strict-names           do NOT require patterns to match objects
       --on-error-stop             stop checking at end of first corrupt page
       --parent-check              check index parent/child relationships
       --rootdescend               search from root page to refind tuples
       --skip=OPTION               do NOT check "all-frozen" or "all-visible" blocks
       --startblock=BLOCK          begin checking table(s) at the given block number
   %s [OPTION]... [DBNAME]
   -?, --help                      show this help, then exit
   -D, --exclude-database=PATTERN  do NOT check matching database(s)
   -I, --exclude-index=PATTERN     do NOT check matching index(es)
   -P, --progress                  show progress information
   -R, --exclude-relation=PATTERN  do NOT check matching relation(s)
   -S, --exclude-schema=PATTERN    do NOT check matching schema(s)
   -T, --exclude-table=PATTERN     do NOT check matching table(s)
   -U, --username=USERNAME         user name to connect as
   -V, --version                   output version information, then exit
   -W, --password                  force password prompt
   -a, --all                       check all databases
   -d, --database=PATTERN          check matching database(s)
   -e, --echo                      show the commands being sent to the server
   -h, --host=HOSTNAME             database server host or socket directory
   -i, --index=PATTERN             check matching index(es)
   -j, --jobs=NUM                  use this many concurrent connections to the server
   -p, --port=PORT                 database server port
   -r, --relation=PATTERN          check matching relation(s)
   -s, --schema=PATTERN            check matching schema(s)
   -t, --table=PATTERN             check matching table(s)
   -v, --verbose                   write a lot of output
   -w, --no-password               never prompt for password
 %*s/%s relations (%d%%), %*s/%s pages (%d%%) %*s/%s relations (%d%%), %*s/%s pages (%d%%) %*s %*s/%s relations (%d%%), %*s/%s pages (%d%%) (%s%-*.*s) %s %s checks objects in a PostgreSQL database for corruption.

 %s home page: <%s>
 Are %s's and amcheck's versions compatible? Cancel request sent
 Could not send cancel request:  Try "%s --help" for more information.
 Usage:
 btree index "%s.%s.%s":
 btree index "%s.%s.%s": btree checking function returned unexpected number of rows: %d cannot specify a database name with --all cannot specify both a database name and database patterns checking btree index "%s.%s.%s" checking heap table "%s.%s.%s" command was: %s could not connect to database %s: out of memory database "%s": %s end block out of bounds end block precedes start block error sending command to database "%s": %s error:  fatal:  heap table "%s.%s.%s", block %s, offset %s, attribute %s:
 heap table "%s.%s.%s", block %s, offset %s:
 heap table "%s.%s.%s", block %s:
 heap table "%s.%s.%s":
 in database "%s": using amcheck version "%s" in schema "%s" including database "%s" internal error: received unexpected database pattern_id %d internal error: received unexpected relation pattern_id %d invalid argument for option %s invalid end block invalid start block no btree indexes to check matching "%s" no connectable databases to check matching "%s" no databases to check no heap tables to check matching "%s" no relations to check no relations to check in schemas matching "%s" no relations to check matching "%s" number of parallel jobs must be at least 1 query failed: %s query was: %s query was: %s
 skipping database "%s": amcheck is not installed start block out of bounds too many command-line arguments (first is "%s") warning:  Project-Id-Version: pg_amcheck (PostgreSQL 14)
Report-Msgid-Bugs-To: pgsql-bugs@lists.postgresql.org
POT-Creation-Date: 2021-08-25 17:21+0900
PO-Revision-Date: 2021-08-25 11:19+0900
Last-Translator: 
Language-Team: 
Language: ja
MIME-Version: 1.0
Content-Type: text/plain; charset=UTF-8
Content-Transfer-Encoding: 8bit
X-Generator: Poedit 1.8.13
 
B-treeインデックス検査オプション:
 
接続オプション:
 
その他のオプション:
 
バグは<%s>に報告してください。
 
テーブル検査オプション:
 
対象指定オプション:
       --endblock=BLOCK            テーブルの検索を指定したブロック番号までで停止
                                  する
       --exclude-toast-pointers    リレーションTOASTポインタを追跡「しない」
       --heapallindexed            すべてのヒープタプルがインデックス中に見つか
                                  ることを検証する
       --install-missing           足りない機能拡張をインストールする
       --maintenance-db=DBNAME     代替の保守データベース
       --no-dependent-indexes      リレーションのリストをインデックスを含むように
                                  拡張「しない」
       --no-dependent-toast        リレーションのリストをTOASTテーブルを含むよう
                                  に拡張「しない」
       --no-strict-names           パターンにオブジェクトが合致しないことを許容
                                  する
       --on-error-stop             検査を最初の破壊ページで停止する
       --parent-check              インデックスの親子関係を検査する
       --rootdescend               タプルの再探索をルートページから行う
       --skip=OPTION               "all-frozen"あるいは"all-visible"である
                                  ブロックを検査「しない」
       --startblock=BLOCK          テーブルの検索を指定したブロック番号から開始
                                  する
   %s [オプション]... [データベース名]
   -?, --help                      このヘルプを表示して終了
   -D, --exclude-database=PATTERN  合致するデータベースを検査「しない」
   -I, --exclude-index=PATTERN     合致するインデックスを検査「しない」
   -P, --progress                  進捗状況を表示する
   -R, --exclude-relation=PATTERN  合致するリレーションを検査「しない」
   -S, --exclude-schema=PATTERN    合致するスキーマを検査「しない」
   -T, --exclude-table=PATTERN     合致するテーブルを検査「しない」
   -U, --username=USERNAME         接続に用いるユーザー名
   -V, --version                   バージョン情報を表示して終了
   -W, --password                  パスワード要求を強制する
   -a, --all                       すべてのデータベースを検査する
   -d, --database=PATTERN          合致するデータベースを検査する
   -e, --echo                      サーバーに送られるコマンドを表示
   -h, --host=HOSTNAME             データベースサーバーのホストまたはソケット
                                  ディレクトリ
   -i, --index=PATTERN             合致するインデックスを検査する
   -j, --jobs=NUM                  使用するサーバー接続数を指定する
   -p, --port=PORT                 データベースサーバーのポート
   -r, --relation=PATTERN          合致するリレーションを検査する
   -s, --schema=PATTERN            合致するスキーマを検査する
   -t, --table=PATTERN             合致するテーブルを検査する
   -v, --verbose                   多くのメッセージを出力します
   -w, --no-password               パスワードを要求しない
 %*s/%s リレーション (%d%%)、 %*s/%s ページ (%d%%) %*s/%s リレーション (%d%%)、 %*s/%s ページ (%d%%) %*s %*s/%s リレーション (%d%%)、 %*s/%s ページ (%d%%), (%s%-*.*s) %s %sはPostgreSQLデータベース内のオブジェクトの破損の検査を行います。

 %s ホームページ: <%s>
 %sとamcheckのバージョンは合っていますか? キャンセル要求を送信しました
 キャンセル要求を送信できませんでした:  詳細は"%s --help"で確認してください。
 使用方法:
 btreeインデックス"%s.%s.%s"の検査中
 btreeインデックス"%s.%s.%s": btree検査関数が予期しない数の行を返却しました: %d データベース名を -all と同時に指定することはできません データベース名とデータベースパターンは同時に指定できません btreeインデックス"%s.%s.%s"の検査中 ヒープテーブル"%s.%s.%s"の検査中 コマンド: %s データベース%sに接続できませんでした: メモリ不足 データベース"%s": %s 終了ブロックが範囲外 終了ブロックが開始ブロックの前にあります データベース"%s"へのコマンド送出中のエラー: %s エラー:  致命的エラー:  ヒープテーブル"%s.%s.%s"、ブロック%s、オフセット%s、属性%s:
 ヒープテーブル"%s.%s.%s"、ブロック%s、オフセット%s:
 ヒープテーブル"%s.%s.%s"、ブロック%sの検査中
 ヒープテーブル"%s.%s.%s"の検査中
 データベース"%1$s": スキーマ%3$sのamcheckバージョン"%2$s"を使用 データベース"%s"を含めます 内部エラー: 予期しないデータベースパターンID%dを受信しました 内部エラー: 予期しないリレーションパターンID%dを受信しました オプション%sの引数が不正です 不正な終了ブロック 不正な開始ブロック "%s"に合致する検査すべきbtreeインデックスがありません "%s”に合致する検査すべき接続可能なデータベースがありません 検査すべきデータベースがありません "%s"に合致する検査すべきヒープテーブルがありません 検査すべきリレーションがありません "%s"に合致するスキーマに検査すべきリレーションがありません "%s"に合致する検査すべきリレーションがありません 並列ジョブの数は最低でも1以上でなければなりません 問い合わせが失敗しました: %s 問い合わせ: %s 問い合わせ: %s
 データベース"%s"をスキップします: amcheckがインストールされていません 開始ブロックが範囲外 コマンドライン引数が多すぎます (先頭は"%s") 警告:  