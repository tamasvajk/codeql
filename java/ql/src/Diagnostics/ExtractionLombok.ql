/**
 * @name Lombok
 * @description A list of extraction diagnostics containing lombok.
 * @kind diagnostic
 * @id java/diagnostics/lombok
 */

import java
import DiagnosticsReporting
import semmle.code.java.Diagnostics

from Diagnostic d, string msg, string f
where
  msg = d.getMessage() and
  exists(msg.indexOf("Skipping Lombok-ed source file")) and
  f = msg.substring(32, msg.length())
select f
