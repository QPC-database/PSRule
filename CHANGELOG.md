
## Unreleased

## v0.3.0

What's changed since v0.2.0:

- Added support for pipelining with `Exists`, `Within`, `Match` and `TypeOf` keywords [#90](https://github.com/BernieWhite/PSRule/issues/90)
- Added support for packaging rules in modules [#16](https://github.com/BernieWhite/PSRule/issues/16)
- Import objects from YAML or JSON format [#75](https://github.com/BernieWhite/PSRule/issues/75)
  - Added support for input de-serialization from FileInfo objects [#95](https://github.com/BernieWhite/PSRule/issues/95)
- Support nested TargetObjects [#77](https://github.com/BernieWhite/PSRule/issues/77)
- Export variables to improve authoring experience [#83](https://github.com/BernieWhite/PSRule/issues/83)
- Binding improvements:
  - Added object type binding and dynamic filtering for rules [#82](https://github.com/BernieWhite/PSRule/issues/82)
  - Added support for indexed and quoted field names [#86](https://github.com/BernieWhite/PSRule/issues/86)
  - Added support for case-sensitive binding operations [#87](https://github.com/BernieWhite/PSRule/issues/87)
    - Binding ignores case by default. Set option `Binding.CaseSensitive` to `true` to enable case-sensitivity.
  - Support TargetName binding of nested properties [#71](https://github.com/BernieWhite/PSRule/issues/71)
- Added online help links to keywords [#72](https://github.com/BernieWhite/PSRule/issues/72)
- Added schema for PSRule options [#74](https://github.com/BernieWhite/PSRule/issues/74)
- **Breaking change** - Changed parameter alias for `-Path` from `-f` to `-p` [#99](https://github.com/BernieWhite/PSRule/issues/99)
- **Breaking change** - The `-TargetName` parameter of the `Hint` keyword has been deprecated [#81](https://github.com/BernieWhite/PSRule/issues/81)
  - `-TargetName` parameter not longer sets the pipeline object _TargetName_ and generates a warning instead.
  - The `-TargetName` will be completely removed in **v0.4.0**, at which time using the parameter will generate an error.

What's changed since pre-release v0.3.0-B190231

- Added support for input de-serialization from FileInfo objects [#95](https://github.com/BernieWhite/PSRule/issues/95)
- **Breaking change** - Changed parameter alias for `-Path` from `-f` to `-p` [#99](https://github.com/BernieWhite/PSRule/issues/99)

## v0.3.0-B190231 (pre-release)

- Added support for pipelining with `Exists`, `Within`, `Match` and `TypeOf` keywords [#90](https://github.com/BernieWhite/PSRule/issues/90)
- Fix empty YAML object causes format de-serialize to fail [#92](https://github.com/BernieWhite/PSRule/issues/92)

## v0.3.0-B190224 (pre-release)

- Export variables to improve authoring experience [#83](https://github.com/BernieWhite/PSRule/issues/83)
- Added support for packaging rules in modules [#16](https://github.com/BernieWhite/PSRule/issues/16)
- Added support for indexed and quoted field names [#86](https://github.com/BernieWhite/PSRule/issues/86)
- Added object type binding and dynamic filtering for rules [#82](https://github.com/BernieWhite/PSRule/issues/82)
- Added support for case-sensitive binding operations [#87](https://github.com/BernieWhite/PSRule/issues/87)
  - Binding ignores case by default. Set option `Binding.CaseSensitive` to `true` to enable case-sensitivity.
- **Breaking change** - The `-TargetName` parameter of the `Hint` keyword has been deprecated [#81](https://github.com/BernieWhite/PSRule/issues/81)
  - `-TargetName` parameter not longer sets the pipeline object _TargetName_ and generates a warning instead.
  - The `-TargetName` will be completely removed in **v0.4.0**, at which time using the parameter will generate an error.

## v0.3.0-B190208 (pre-release)

- Added online help links to keywords [#72](https://github.com/BernieWhite/PSRule/issues/72)
- Added schema for PSRule options [#74](https://github.com/BernieWhite/PSRule/issues/74)
- Import objects from YAML or JSON format [#75](https://github.com/BernieWhite/PSRule/issues/75)
- Support TargetName binding of nested properties [#71](https://github.com/BernieWhite/PSRule/issues/71)
- Support nested TargetObjects [#77](https://github.com/BernieWhite/PSRule/issues/77)

## v0.2.0

What's changed since v0.1.0:

- Added support for cross-platform environments (Windows, Linux and macOS) [#49](https://github.com/BernieWhite/PSRule/issues/49)
- Added support for nested field names with `Exists`, `Within` and `Match` keywords [#60](https://github.com/BernieWhite/PSRule/issues/60)
- Added support for rule configuration using baselines [#17](https://github.com/BernieWhite/PSRule/issues/17)
- Use rule description when hint message not set [#61](https://github.com/BernieWhite/PSRule/issues/61)
- Allow objects to be suppressed by _TargetName_ for individual rules [#13](https://github.com/BernieWhite/PSRule/issues/13)
- Allow binding of _TargetName_ to custom property [#44](https://github.com/BernieWhite/PSRule/issues/44)
- Custom functions can be used to bind _TargetName_ [#44](https://github.com/BernieWhite/PSRule/issues/44)
- Objects that are unable to bind a _TargetName_ will use a SHA1 object hash for _TargetName_ [#44](https://github.com/BernieWhite/PSRule/issues/44)
- Added `Test-PSRuleTarget` command to return an overall `$True` or `$False` after evaluating rules for an object [#30](https://github.com/BernieWhite/PSRule/issues/30)
- Improve reporting of inconclusive results and objects that are not processed by any rule [#46](https://github.com/BernieWhite/PSRule/issues/46)
  - Inconclusive results and objects not processed will return a warning by default.
- Fix propagation of informational messages to host from rule scripts and definitions [#48](https://github.com/BernieWhite/PSRule/issues/48)
- Fix Get-PSRule generates exception when no .rule.ps1 scripts exist in path [#53](https://github.com/BernieWhite/PSRule/issues/53)
- Fix LocalizedData.PathNotFound warning when no .rule.ps1 scripts exist in path [#54](https://github.com/BernieWhite/PSRule/issues/54)

What's changed since pre-release v0.2.0-B190121

- No additional changes

## v0.2.0-B190121 (pre-release)

- Added support for nested field names with `Exists`, `Within` and `Match` keywords [#60](https://github.com/BernieWhite/PSRule/issues/60)
- Added support for rule configuration using baselines [#17](https://github.com/BernieWhite/PSRule/issues/17)
- Use rule description when hint message not set [#61](https://github.com/BernieWhite/PSRule/issues/61)

## v0.2.0-B190113 (pre-release)

- Fix Get-PSRule generates exception when no .rule.ps1 scripts exist in path [#53](https://github.com/BernieWhite/PSRule/issues/53)
- Fix LocalizedData.PathNotFound warning when no .rule.ps1 scripts exist in path [#54](https://github.com/BernieWhite/PSRule/issues/54)
- **Breaking change** - Renamed `Test-PSRule` cmdlet to `Test-PSRuleTarget` which aligns more closely to the verb-noun naming standard [#57](https://github.com/BernieWhite/PSRule/issues/57)

## v0.2.0-B190105 (pre-release)

- Allow objects to be suppressed by _TargetName_ for individual rules [#13](https://github.com/BernieWhite/PSRule/issues/13)
- Allow binding of _TargetName_ to custom property [#44](https://github.com/BernieWhite/PSRule/issues/44)
- Custom functions can be used to bind _TargetName_ [#44](https://github.com/BernieWhite/PSRule/issues/44)
- Objects that are unable to bind a _TargetName_ will use a SHA1 object hash for _TargetName_ [#44](https://github.com/BernieWhite/PSRule/issues/44)
- Added `Test-PSRule` command to return an overall `$True` or `$False` after evaluating rules for an object [#30](https://github.com/BernieWhite/PSRule/issues/30)
- Improve reporting of inconclusive results and objects that are not processed by any rule [#46](https://github.com/BernieWhite/PSRule/issues/46)
  - Inconclusive results and objects not processed will return a warning by default.
- Fix propagation of informational messages to host from rule scripts and definitions [#48](https://github.com/BernieWhite/PSRule/issues/48)
- Added support for cross-platform environments (Windows, Linux and macOS) [#49](https://github.com/BernieWhite/PSRule/issues/49)

## v0.1.0

- Initial release

What's changed since pre-release v0.1.0-B181235:

- Fix outcome filtering of summary results [#33](https://github.com/BernieWhite/PSRule/issues/33)
- Fix target object counter in verbose logging [#35](https://github.com/BernieWhite/PSRule/issues/35)
- Fix hashtable keys should be handled as fields [#36](https://github.com/BernieWhite/PSRule/issues/36)

## v0.1.0-B181235 (pre-release)

- RuleId and RuleName are now independent. Rules are created with a name, and the RuleId is generated based on rule name and file name
  - Rules with the same name can exist and be cross linked with DependsOn, as long a the script file name is different
- Added `-Not` to `Exists` keyword
- Improved verbose logging of `Exists`, `AllOf`, `AnyOf` keywords and core engine
- **Breaking change** - Renamed outcome filtering parameters to align to type name and increase clarity
  - `Invoke-PSRule` has a `-Outcome` parameter instead of `-Status`
  - `-Outcome` supports values of `Pass`, `Fail`, `Error`, `None`, `Processed` and `All`

## v0.1.0-B181222 (pre-release)

- Added rule tags to results to enable grouping and sorting [#14](https://github.com/BernieWhite/PSRule/issues/14)
- Added support to check for rule tag existence. Use `*` for tag value on `-Tag` parameter with `Invoke-PSRule` and `Get-PSRule`
- Added option to report rule summary using `-As` parameter of `Invoke-PSRule` [#12](https://github.com/BernieWhite/PSRule/issues/12)

## v0.1.0-B181212 (pre-release)

- Initial pre-release