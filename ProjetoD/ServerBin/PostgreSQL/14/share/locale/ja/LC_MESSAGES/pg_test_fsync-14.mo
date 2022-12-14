??          ?   %   ?      P  1   Q  2   ?  /   ?     ?  8        :     T     o     ?     ?  (   ?  U   ?  [   D  K   ?  c   ?     P  .   k  E   ?  &   ?  +        3     N     [     _     d  ?  q  M     M   g  @   ?     ?  t   	     ?	     ?	     ?	     ?	  &   ?	     &
  ?   C
  ?   ?
  P   q  ?   ?     p  ^   ?  w   ?  3   d  D   ?  9   ?          &     3     A                      
              	                                                                                         
Compare file sync methods using one %dkB write:
 
Compare file sync methods using two %dkB writes:
 
Compare open_sync with different write sizes:
 
Non-sync'ed %dkB writes:
 
Test if fsync on non-write file descriptor is honored:
  1 * 16kB open_sync write  2 *  8kB open_sync writes  4 *  4kB open_sync writes  8 *  2kB open_sync writes %13.3f ops/sec  %6.0f usecs/op
 %u second per test
 %u seconds per test
 (If the times are similar, fsync() can sync data written on a different
descriptor.)
 (This is designed to compare the cost of writing 16kB in different write
open_sync sizes.)
 (in wal_sync_method preference order, except fdatasync is Linux's default)
 * This file system and its mount options do not support direct
  I/O, e.g. ext4 in journaled mode.
 16 *  1kB open_sync writes Direct I/O is not supported on this platform.
 O_DIRECT supported on this platform for open_datasync and open_sync.
 Try "%s --help" for more information.
 Usage: %s [-f FILENAME] [-s SECS-PER-TEST]
 could not open output file fsync failed n/a n/a* write failed Project-Id-Version: pg_test_fsync (PostgreSQL 14)
Report-Msgid-Bugs-To: pgsql-bugs@lists.postgresql.org
POT-Creation-Date: 2021-08-25 17:22+0900
PO-Revision-Date: 2021-05-17 14:56+0900
Last-Translator: Michihide Hotta <hotta@net-newbie.com>
Language-Team: 
Language: ja
MIME-Version: 1.0
Content-Type: text/plain; charset=UTF-8
Content-Transfer-Encoding: 8bit
Plural-Forms: nplurals=1; plural=0;
X-Generator: Poedit 1.8.13
 
%dkBの書込みを1回行ってファイル同期方法を比較します:
 
%dkBの書込みを2回行ってファイル同期方法を比較します:
 
open_sync を異なった書込みサイズで比較します:
 
%dkBの同期なし書込み:
 
書き込みのないのファイルディスクリプタ上のfsyncが無視されないかをテストします:
  1 * 16kB open_sync書込み  2 *  8kB open_sync書込み  4 *  4kB open_sync書込み  8 *  2kB open_sync書込み %13.3f 操作/秒  %6.0f μ秒/操作
 テスト1件あたり%u秒
 （もし実行時間が同等であれば、fsync()は異なったファイルディスクリプタ上で
データをsyncできることになります。）
 (これはopen_syncの書込みサイズを変えながら、16kBの書込みのコストを比較する
よう指定されています。)
 (Linuxのデフォルトであるfdatasyncを除きwal_sync_methodの優先順)
 * このファイルシステムとそのマウントオプションではダイレクトI/Oをサポート
  していません。例）ジャーナルモードの ext4。
 16 *  1kB open_sync書込み このプラットフォームではダイレクトI/Oがサポートされていません。
 このプラットフォームではopen_datasyncとopen_syncについてO_DIRECTが
サポートされています。
 詳細は"%s --help"で確認してください。
 使用法: %s [-f ファイル名] [-s テストあたりの秒数]
 出力ファイルをオープンできませんでした fsyncに失敗 利用不可 利用不可* 書き込みに失敗 