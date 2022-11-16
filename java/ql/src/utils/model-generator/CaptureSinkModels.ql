/**
 * @name Capture sink models.
 * @description Finds public methods that act as sinks as they flow into a known sink.
 * @kind path-problem
 * @id java/utils/model-generator/sink-models
 * @tags model-generator
 */

import utils.modelgenerator.internal.CaptureModels
import java
import DataFlow::PathGraph
import semmle.code.java.dataflow.FlowSources
import semmle.code.java.dataflow.ExternalFlow as ExternalFlow

class Activate extends ActiveConfiguration {
  override predicate activateToSinkConfig() { any() }
}

// bindingset[row]
// private string trim(string row) {
//   result =
//     row.substring(0, row.indexOf(";", 1, 0)) +
//       row.substring(row.indexOf(";", 6, 0), row.indexOf(";", 7, 0))
// }
// private string getManualSinkModels() {
//   exists(ExternalFlow::SinkModelCsv sm, string row |
//     sm.row(row) and
//     result = trim(row)
//   )
// }
// from DataFlowTargetApi api, string sink, string short
// where
//   sink = captureSink(api) and
//   short = trim(sink) and
//   not short = getManualSinkModels()
// select sink order by sink
// -------------------
from
  PropagateToSinkConfiguration cfg, DataFlow::PathNode source, DataFlow::PathNode sink, string kind,
  DataFlowTargetApi api
where
  cfg.hasFlowPath(source, sink) and
  kind = sink.toString() and
  api = source.getNode().getEnclosingCallable()
select source.getNode(), source, sink, "$@", source.getNode(),
  asSinkModelForTest(api, source.getNode(), kind)
//------------------
// bindingset[kind]
// predicate isRelevantSinkKind(string kind) {
//   not kind = "logging" and
//   not kind.matches("regex-use%") and
//   not kind = "write-file" and
//   not kind = "create-file"
// }
// private import semmle.code.java.dataflow.internal.FlowSummaryImplSpecific as FlowSummaryImplSpecific
// private predicate test1(MethodAccess ma, Method m, DataFlow::ImplicitInstanceAccess iia) {
//   ma.getMethod() = m and
//   m.getName() = "openConnection" and
//   ma.getLocation().getFile().getStem() = "URL" and
//   ma.getLocation().getStartLine() = 1131 and
//   ma.isOwnMethodAccess() and
//   iia.getInstanceAccess().isImplicitMethodQualifier(ma) and
//   ExternalFlow::sinkNode(iia, _)
// }
// private predicate test2(MethodAccess ma, Method m, DataFlow::Node n) {
//   ma.getMethod() = m and
//   m.getName() = "openConnection" and
//   ma.getLocation().getFile().getStem() = "JarURLConnection" and
//   ma.getLocation().getStartLine() = 84 and
//   n.asExpr() = ma.getQualifier() and
//   ExternalFlow::sinkNode(n, _)
// }
