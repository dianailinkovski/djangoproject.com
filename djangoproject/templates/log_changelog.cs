#
# ChangeLog for <?cs var:log.path ?>
#
# Generated by Trac <?cs var:trac.version ?>
# <?cs var:trac.time ?>
#
<?cs each:item = $log.items ?>
<?cs var:log.changes[item.rev].date ?> <?cs
     var:log.changes[item.rev].author ?> [<?cs var:item.rev ?>]
<?cs each:file = $log.changes[item.rev].files ?>
	* <?cs var:file ?>:<?cs
/each ?>
<?cs var:log.changes[item.rev].message ?>
<?cs /each ?>
