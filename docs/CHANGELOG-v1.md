# Change log

See [upgrade notes][upgrade-notes] for helpful information when upgrading from previous versions.

[upgrade-notes]: upgrade-notes.md

## Unreleased

## v1.0.2

What's changed since v1.0.1:

- Engineering:
  - Bump Manatee.Json from 13.0.4 to 13.0.5. [#619](https://github.com/microsoft/PSRule/pull/619)
- Bug fixes:
  - Fixed `GetContent` processing of `InputFileInfo`. [#625](https://github.com/microsoft/PSRule/issues/625)
  - Fixed null reference of rule reason with wide output. [#626](https://github.com/microsoft/PSRule/issues/626)
  - Fixed markdown help handling of include code blocks with `[`. [#627](https://github.com/microsoft/PSRule/issues/627)
  - Fixed markdown help inclusion of fenced code blocks in notes and description. [#628](https://github.com/microsoft/PSRule/issues/628)

## v1.0.1

What's changed since v1.0.0:

- Bug fixes:
  - Fixed module source key has already been added. [#608](https://github.com/microsoft/PSRule/issues/608)

## v1.0.0

What's changed since v0.22.0:

- General improvements:
  - Added rule help link in failed `Assert-PSRule` output. [#595](https://github.com/microsoft/PSRule/issues/595)
- Engineering:
  - **Breaking change**: Removed deprecated `$Rule` properties. [#495](https://github.com/microsoft/PSRule/pull/495)
  - Bump Manatee.Json from 13.0.3 to 13.0.4. [#591](https://github.com/microsoft/PSRule/pull/591)

What's changed since pre-release v1.0.0-B2011028:

- No additional changes.

## v1.0.0-B2011028 (pre-release)

What's changed since v0.22.0:

- General improvements:
  - Added rule help link in failed `Assert-PSRule` output. [#595](https://github.com/microsoft/PSRule/issues/595)
- Engineering:
  - **Breaking change**: Removed deprecated `$Rule` properties. [#495](https://github.com/microsoft/PSRule/pull/495)
  - Bump Manatee.Json from 13.0.3 to 13.0.4. [#591](https://github.com/microsoft/PSRule/pull/591)