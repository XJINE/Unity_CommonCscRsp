# Unity_CommonCscRsp

This assets add ``crc.rsp`` file just under your Unity project ``Assets/``.
This hides following warnings.

## Import to Your Project

You can import this asset from UnityPackage.

- [CommonCscRsp.unitypackage](https://github.com/XJINE/Unity_CommonCscRsp/blob/master/CommonCscRsp.unitypackage)

## Warnings

### 0649

> Field '~' is never assigned to, and will always have its default value ~

Ex. when the protected SerializeField field value is not set.

### 0618

> '~' is obsolete: `Use ~ '

Ex. when some codes are set the Obsolete attribute.
Ex. UNET(HLAPI).

### 109

> The member '~' does not hide an accessible member. The new keyword is not required.

Ex. when some MonoBhaviour have a same name field which defined in the base class.
Ex. renderer, camera or any others.

## Comment

``csc.rsp`` is able to write some comments with ``#`` syntax.
However, in some Unity ver. like 2019, it makes errors.