﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dicom.Network {
	public interface IDicomCStoreProvider {
		DicomCStoreResponse OnCStoreRequest(DicomCStoreRequest request);
	}
}
