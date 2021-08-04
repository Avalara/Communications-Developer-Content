# coding: utf-8

"""
    SaasPro

    APIs to interface with communications tax engine.<br />The API requires Basic authentication.<br />Users with access to multiple clients must also set request header parameter for <code>client_id</code>.<br />Set <code>client_profile_id</code> to specify profile to be used for taxation.<br /><br />Effective January 1st, 2022 all Avalara products will be enforcing TLS 1.2 server-side. Please ensure that your implementation sets a minimal of TLS 1.2 encryption when making web requests to Avalara APIs.  # noqa: E501

    The version of the OpenAPI document: v2
    Generated by: https://openapi-generator.tech
"""


from __future__ import absolute_import

import unittest
import datetime

import avalara.comms.rest.v2
from avalara.comms.rest.v2.models.exclusion import Exclusion  # noqa: E501
from avalara.comms.rest.v2.rest import ApiException

class TestExclusion(unittest.TestCase):
    """Exclusion unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional):
        """Test Exclusion
            include_option is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # model = avalara.comms.rest.v2.models.exclusion.Exclusion()  # noqa: E501
        if include_optional :
            return Exclusion(
                ctry = '0', 
                st = '0', 
                excl = True
            )
        else :
            return Exclusion(
        )

    def testExclusion(self):
        """Test Exclusion"""
        inst_req_only = self.make_instance(include_optional=False)
        inst_req_and_optional = self.make_instance(include_optional=True)


if __name__ == '__main__':
    unittest.main()
