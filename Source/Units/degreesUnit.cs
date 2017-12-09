//--------------------------------------//               PowerUI////        For documentation or //    if you have any issues, visit//        powerUI.kulestar.com////    Copyright � 2013 Kulestar Ltd//          www.kulestar.com//--------------------------------------using System;using UnityEngine;namespace Css.Units{		/// <summary>	/// Represents an instance of an angle in degrees.	/// </summary>		public class DegreesUnit:AngleUnit{						public DegreesUnit(){}						public DegreesUnit(float degr){						RawValue=degr * Mathf.Deg2Rad;					}				public override float DisplayNumber{			get{				return (RawValue*Mathf.Rad2Deg);			}		}				public override string ToString(){			return DisplayNumber+"deg";		}				public override void OnValueReady(CssLexer lexer){			// Map to radians:			RawValue *= Mathf.Deg2Rad;		}				protected override Value Clone(){			DegreesUnit result=new DegreesUnit();			result.RawValue=RawValue;			return result;		}				public override string[] PostText{			get{				return new string[]{"deg"};			}		}			}	}