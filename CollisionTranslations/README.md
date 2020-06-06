To Add Collision Translations
---

 - Use `-` as a folder separator. This is needed for non-unique .col files such as object.col.<br>
e.g. `wp03/shell/collision/object.col.csv` becomes `wp03-shell-collision-object.col.csv`.
 - The csv name (excl. extension) must be the full .col filename (incl. extension).<br>
e.g. `wp03.col` becomes `wp03.col.csv`.

Columns format is: `Move_Id,untranslated,translated,description`. (The exact column name doesn't matter; what does is the order.)<br>
The untranslated name isn't used, but is great for reference.<br>
'description' can be left blank/empty.

For now, English is the only language supported by translations here. If you want to provide translations in another language for this, open an issue and I'll rework the csv structure for it.