// generated by codegen/codegen.py, do not edit
import codeql.swift.elements
import TestUtils

query predicate instances(
  VariadicSequenceType x, string getName__label, string getName, string getCanonicalType__label,
  Type getCanonicalType, string getBaseType__label, Type getBaseType
) {
  toBeTested(x) and
  not x.isUnknown() and
  getName__label = "getName:" and
  getName = x.getName() and
  getCanonicalType__label = "getCanonicalType:" and
  getCanonicalType = x.getCanonicalType() and
  getBaseType__label = "getBaseType:" and
  getBaseType = x.getBaseType()
}
