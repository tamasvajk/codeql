private import codeql.swift.generated.stmt.ReturnStmt

module Impl {
  class ReturnStmt extends Generated::ReturnStmt {
    override string toStringImpl() {
      if this.hasResult() then result = "return ..." else result = "return"
    }
  }
}
