??    8      ?  O   ?      ?  X   ?  
   2     =  5   Y  P   ?  5   ?  A     :   X  2   ?  1   ?  G   ?  3   @  *   t     ?  T   ?          "     6     J     h     ?     ?     ?     ?  k   ?  &   V	     }	  a   ?	     ?	     
  ;   &
     b
  !   |
     ?
  (   ?
  3   ?
       )   5  5   _  .   ?  -   ?  )   ?  "        ?     G  3   O  +   ?     ?  2   ?  !   ?  )         J  /   a     ?  	   ?  ?  ?  o   q     ?     ?  @     U   Q  1   ?  F   ?  Q      C   r  C   ?  ^   ?  :   Y  7   ?     ?  ?   ?     u  $   ?  &   ?  .   ?  =     =   K  /   ?  '   ?  ,   ?  ?     3   ?     ?  ?     @   ?  =   ?  Q     K   c  A   ?  ;   ?  L   -  f   z  0   ?  L     ?   _  Q   ?  Q   5  K   ?  0   ?            O   %  :   u  9   ?  M   ?  .   8  >   g  3   ?  =   ?  6        O     8          .   )                   !   #               /          4   (   *             ,       0       3      &                               7   6          1            2   '       $                          +              "              
          %             5      -   	        
If no data directory (DATADIR) is specified, the environment variable PGDATA
is used.

 
Options:
   %s [OPTION]... [DATADIR]
   -?, --help               show this help, then exit
   -N, --no-sync            do not wait for changes to be written safely to disk
   -P, --progress           show progress information
   -V, --version            output version information, then exit
   -c, --check              check data checksums (default)
   -d, --disable            disable data checksums
   -e, --enable             enable data checksums
   -f, --filenode=FILENODE  check only relation with specified filenode
   -v, --verbose            output verbose messages
  [-D, --pgdata=]DATADIR    data directory
 %*s/%s MB (%d%%) computed %s enables, disables, or verifies data checksums in a PostgreSQL database cluster.

 %s home page: <%s>
 Bad checksums:  %s
 Blocks scanned: %s
 Checksum operation completed
 Checksums disabled in cluster
 Checksums enabled in cluster
 Data checksum version: %u
 Files scanned:  %s
 Report bugs to <%s>.
 The database cluster was initialized with block size %u, but pg_checksums was compiled with block size %u.
 Try "%s --help" for more information.
 Usage:
 checksum verification failed in file "%s", block %u: calculated checksum %X but block contains %X checksums enabled in file "%s" checksums verified in file "%s" cluster is not compatible with this version of pg_checksums cluster must be shut down could not open directory "%s": %m could not open file "%s": %m could not read block %u in file "%s": %m could not read block %u in file "%s": read %d of %d could not stat file "%s": %m could not write block %u in file "%s": %m could not write block %u in file "%s": wrote %d of %d data checksums are already disabled in cluster data checksums are already enabled in cluster data checksums are not enabled in cluster database cluster is not compatible error:  fatal:  invalid filenode specification, must be numeric: %s invalid segment number %d in file name "%s" no data directory specified option -f/--filenode can only be used with --check pg_control CRC value is incorrect seek failed for block %u in file "%s": %m syncing data directory too many command-line arguments (first is "%s") updating control file warning:  Project-Id-Version: pg_checksums (PostgreSQL 14)
Report-Msgid-Bugs-To: pgsql-bugs@lists.postgresql.org
POT-Creation-Date: 2021-08-25 17:21+0900
PO-Revision-Date: 2021-05-18 17:11+0900
Last-Translator: Kyotaro Horiguchi <horikyota.ntt@gmail.com>
Language-Team: Japan PostgreSQL Users Group <jpug-doc@ml.postgresql.jp>
Language: ja
MIME-Version: 1.0
Content-Type: text/plain; charset=UTF-8
Content-Transfer-Encoding: 8bit
X-Generator: Poedit 1.8.13
 
データディレクトリ(DATADIR)が指定されない場合、PGDATA環境変数が使用されます。

 
オプション:
   %s [OPTION]... [DATADIR]
   -?, --help               このヘルプを表示して終了
   -N, --no-sync            ディスクへの安全な書き込みを待機しない
   -P, --progress           進捗情報を表示
   -V, --version            バージョン情報を表示して終了
   -c, --check              データチェックサムを検証(デフォルト)
   -d, --disable            データチェックサムを無効化
   -e, --enable             データチェックサムを有効化
   -f, --filenode=FILENODE  指定したファイルノードのリレーションのみ検証
   -v, --verbose            冗長メッセージを出力
  [-D, --pgdata=]DATADIR    データディレクトリ
 %*s/%s MB (%d%%) 完了 %s はPostgreSQLデータベースクラスタにおけるデータチェックサムの有効化、無効化および検証を行います。

 %s ホームページ: <%s>
 不正なチェックサム数:  %s
 スキャンしたブロック数: %s
 チェックサム操作が完了しました
 クラスタのチェックサムが無効化されました
 クラスタのチェックサムが有効化されました
 データチェックサムバージョン: %u
 スキャンしたファイル数:  %s
 バグは<%s>に報告してください。
 データベースクラスタはブロックサイズ%uで初期化されています、しかしpg_checksumsはブロックサイズ%uでコンパイルされています。
 詳細は"%s --help"で確認してください。
 使用方法:
 ファイル"%s" ブロック%uでチェックサム検証が失敗: 算出したチェックサムは%X 、しかしブロック上の値は%X ファイル"%s"のチェックサムは有効化されました ファイル"%s"のチェックサムは検証されました クラスタはこのバージョンのpg_checksumsと互換性がありません クラスタはシャットダウンされていなければなりません ディレクトリ"%s"をオープンできませんでした: %m ファイル"%s"をオープンできませんでした: %m ファイル"%2$s"で%1$uブロックを読み取れませんでした: %3$m  ファイル"%2$s"のブロック%1$uが読み込めませんでした: %4$d中%3$d読み込み済み ファイル"%s"のstatに失敗しました: %m ファイル"%2$s"で%1$uブロックが書き出せませんでした: %3$m ファイル"%2$s"のブロック%1$uの書き込みに失敗しました: %4$dバイト中%3$dバイトのみ書き込みました クラスタのデータチェックサムはすでに無効になっています クラスタのデータチェックサムはすでに有効になっています クラスタのデータチェックサムは有効になっていません データベースクラスタが非互換です エラー:  致命的エラー:  不正なファイルノード指定、数値である必要があります: %s ファイル名"%2$s"の不正なセグメント番号%1$d データディレクトリが指定されていません オプション-f/--filenodeは--checkを指定したときのみ指定可能 pg_controlのCRC値が正しくありません ファイル"%2$s" ブロック%1$uへのシーク失敗: %3$m データディレクトリを同期しています コマンドライン引数が多すぎます (先頭は"%s") コントロールファイルを更新しています 警告:  