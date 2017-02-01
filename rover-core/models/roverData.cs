﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommsLib;

namespace rover_core.models
{

	public class roverData
	{
		public static roverData Instance
		{
			get; private set;
		} = new roverData();
		public short accelerationX { get; internal set; } = 0;
		public short accelerationY { get; internal set; } = 0;
		public short accelerationZ { get; internal set; } = 0;
		internal double rawencoderLeftOffset { get; set; } = 0.00;
		internal double rawencoderRightOffset { get; set; } = 0.00;
		internal double rawencoderLeft { get; set; } = 0.00;
		internal double rawencoderRight { get; set; } = 0.00;

		public double encoderLeft
		{
			get
			{
				return rawencoderLeft - rawencoderLeftOffset;
			}
		}
		public double encoderRight
		{
			get
			{
				return rawencoderRight - rawencoderRightOffset;
			}
		}
		public bool ledGreen { get; internal set; } = false;
		public bool ledRed { get; internal set; } = false;
		public short magnetX { get; internal set; } = 0;
		public short magnetY { get; internal set; } = 0;
		public short magnetZ { get; internal set; } = 0;

		public short accellTemp { get; internal set; } = 0;
		public short accellStatus { get; internal set; } = 0;
		public short accellX { get; internal set; } = 0;
		public short accellY { get; internal set; } = 0;
		public short accellZ { get; internal set; } = 0;
	}
}