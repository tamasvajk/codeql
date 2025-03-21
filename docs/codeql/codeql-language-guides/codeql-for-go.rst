.. _codeql-for-go:

CodeQL for Go
=============

Experiment and learn how to write effective and efficient queries for CodeQL databases generated from Go codebases.

.. toctree::
   :hidden:

   basic-query-for-go-code
   codeql-library-for-go
   abstract-syntax-tree-classes-for-working-with-go-programs
   analyzing-data-flow-in-go
   customizing-library-models-for-go

-  :doc:`Basic query for Go code <basic-query-for-go-code>`: Learn to write and run a simple CodeQL query.

-  :doc:`CodeQL library for Go <codeql-library-for-go>`: When you're analyzing a Go program, you can make use of the large collection of classes in the CodeQL library for Go.

- `CodeQL CTF: Go and don't return <https://securitylab.github.com/ctf/go-and-dont-return/>`__: Follow the steps that members of GitHub Security Lab went through to find a high severity vulnerability in MinIO, an Amazon S3-compatible object store.

-  :doc:`Abstract syntax tree classes for working with Go programs <abstract-syntax-tree-classes-for-working-with-go-programs>`: CodeQL has a large selection of classes for representing the abstract syntax tree of Go programs.

-  :doc:`Analyzing data flow in Go <analyzing-data-flow-in-go>`: You can use CodeQL to track the flow of data through a Go program to its use.

-  :doc:`Customizing library models for Go <customizing-library-models-for-go>`: You can model frameworks and libraries that your codebase depends on using data extensions and publish them as CodeQL model packs.
