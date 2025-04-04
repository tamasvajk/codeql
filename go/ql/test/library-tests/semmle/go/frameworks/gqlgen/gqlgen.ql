import go
import semmle.go.dataflow.ExternalFlow
import ModelValidation
import utils.test.InlineExpectationsTest

module ResolveParameterTest implements TestSig {
  string getARelevantTag() { result = "resolverParameter" }

  predicate hasActualResult(Location location, string element, string tag, string value) {
    tag = "resolverParameter" and
    exists(Gqlgen::ResolverParameter p |
      element = p.toString() and
      value = "\"" + p.toString() + "\"" and
      p.getLocation() = location
    )
  }
}

import MakeTest<ResolveParameterTest>
