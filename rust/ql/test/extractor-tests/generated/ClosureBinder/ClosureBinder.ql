// generated by codegen, do not edit
import codeql.rust.elements
import TestUtils

query predicate instances(ClosureBinder x) { toBeTested(x) and not x.isUnknown() }

query predicate getGenericParamList(ClosureBinder x, GenericParamList getGenericParamList) {
  toBeTested(x) and not x.isUnknown() and getGenericParamList = x.getGenericParamList()
}
