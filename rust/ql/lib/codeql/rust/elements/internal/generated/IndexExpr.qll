// generated by codegen, do not edit
/**
 * This module provides the generated definition of `IndexExpr`.
 * INTERNAL: Do not import directly.
 */

private import codeql.rust.elements.internal.generated.Synth
private import codeql.rust.elements.internal.generated.Raw
import codeql.rust.elements.Attr
import codeql.rust.elements.Expr
import codeql.rust.elements.internal.ExprImpl::Impl as ExprImpl

/**
 * INTERNAL: This module contains the fully generated definition of `IndexExpr` and should not
 * be referenced directly.
 */
module Generated {
  /**
   * An index expression. For example:
   * ```rust
   * list[42];
   * list[42] = 1;
   * ```
   * INTERNAL: Do not reference the `Generated::IndexExpr` class directly.
   * Use the subclass `IndexExpr`, where the following predicates are available.
   */
  class IndexExpr extends Synth::TIndexExpr, ExprImpl::Expr {
    override string getAPrimaryQlClass() { result = "IndexExpr" }

    /**
     * Gets the `index`th attr of this index expression (0-based).
     */
    Attr getAttr(int index) {
      result =
        Synth::convertAttrFromRaw(Synth::convertIndexExprToRaw(this).(Raw::IndexExpr).getAttr(index))
    }

    /**
     * Gets any of the attrs of this index expression.
     */
    final Attr getAnAttr() { result = this.getAttr(_) }

    /**
     * Gets the number of attrs of this index expression.
     */
    final int getNumberOfAttrs() { result = count(int i | exists(this.getAttr(i))) }

    /**
     * Gets the base of this index expression, if it exists.
     */
    Expr getBase() {
      result =
        Synth::convertExprFromRaw(Synth::convertIndexExprToRaw(this).(Raw::IndexExpr).getBase())
    }

    /**
     * Holds if `getBase()` exists.
     */
    final predicate hasBase() { exists(this.getBase()) }

    /**
     * Gets the index of this index expression, if it exists.
     */
    Expr getIndex() {
      result =
        Synth::convertExprFromRaw(Synth::convertIndexExprToRaw(this).(Raw::IndexExpr).getIndex())
    }

    /**
     * Holds if `getIndex()` exists.
     */
    final predicate hasIndex() { exists(this.getIndex()) }
  }
}
