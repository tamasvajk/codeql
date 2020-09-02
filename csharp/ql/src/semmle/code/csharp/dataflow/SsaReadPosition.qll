private import csharp
private import Ssa

private newtype TSsaReadPosition =
  TSsaReadPositionBlock(BasicBlock bb) {
    exists(Definition v | bb = v.getARead().getAControlFlowNode().getBasicBlock())
  } or
  TSsaReadPositionPhiInputEdge(BasicBlock bbOrig, BasicBlock bbPhi) {
    exists(PhiNode phi | phi.hasInputFromBlock(_, bbOrig) and bbPhi = phi.getBasicBlock())
  }

/**
 * A position at which an SSA variable is read. This includes both ordinary
 * reads occurring in basic blocks and input to phi nodes occurring along an
 * edge between two basic blocks.
 */
class SsaReadPosition extends TSsaReadPosition {
  /** Holds if `v` is read at this position. */
  abstract predicate hasReadOfVar(Definition v);

  /** Gets a textual representation of this SSA read position. */
  abstract string toString();
}

/** A basic block in which an SSA variable is read. */
class SsaReadPositionBlock extends SsaReadPosition, TSsaReadPositionBlock {
  /** Gets the basic block corresponding to this position. */
  BasicBlock getBlock() { this = TSsaReadPositionBlock(result) }

  override predicate hasReadOfVar(Definition v) {
    getBlock() = v.getARead().getAControlFlowNode().getBasicBlock()
  }

  override string toString() { result = "block" }
}

/**
 * An edge between two basic blocks where the latter block has an SSA phi
 * definition. The edge therefore has a read of an SSA variable serving as the
 * input to the phi node.
 */
class SsaReadPositionPhiInputEdge extends SsaReadPosition, TSsaReadPositionPhiInputEdge {
  /** Gets the head of the edge. */
  BasicBlock getOrigBlock() { this = TSsaReadPositionPhiInputEdge(result, _) }

  /** Gets the tail of the edge. */
  BasicBlock getPhiBlock() { this = TSsaReadPositionPhiInputEdge(_, result) }

  override predicate hasReadOfVar(Definition v) {
    exists(PhiNode phi |
      phi.hasInputFromBlock(v, getOrigBlock()) and
      getPhiBlock() = phi.getBasicBlock()
    )
  }

  /** Holds if `inp` is an input to `phi` along this edge. */
  predicate phiInput(PhiNode phi, Definition inp) {
    phi.hasInputFromBlock(inp, getOrigBlock()) and
    getPhiBlock() = phi.getBasicBlock()
  }

  override string toString() { result = "edge" }
}
