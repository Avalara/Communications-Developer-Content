# coding: utf-8

"""
    SaasPro

    APIs to interface with communications tax engine.<br />The API requires Basic authentication.<br />Users with access to multiple clients must also set request header parameter for <code>client_id</code>.<br />Set <code>client_profile_id</code> to specify profile to be used for taxation.<br /><br />Effective January 1st, 2022 all Avalara products will be enforcing TLS 1.2 server-side. Please ensure that your implementation sets a minimal of TLS 1.2 encryption when making web requests to Avalara APIs.  # noqa: E501

    The version of the OpenAPI document: v2
    Generated by: https://openapi-generator.tech
"""


import pprint
import re  # noqa: F401

import six

from avalara.comms.rest.v2.configuration import Configuration


class ServiceInfo(object):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    """
    Attributes:
      openapi_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    openapi_types = {
        'server_time': 'datetime',
        'versions': 'VersionInfo',
        'error': 'str'
    }

    attribute_map = {
        'server_time': 'ServerTime',
        'versions': 'Versions',
        'error': 'Error'
    }

    def __init__(self, server_time=None, versions=None, error=None, local_vars_configuration=None):  # noqa: E501
        """ServiceInfo - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._server_time = None
        self._versions = None
        self._error = None
        self.discriminator = None

        if server_time is not None:
            self.server_time = server_time
        if versions is not None:
            self.versions = versions
        self.error = error

    @property
    def server_time(self):
        """Gets the server_time of this ServiceInfo.  # noqa: E501

        Server time.  # noqa: E501

        :return: The server_time of this ServiceInfo.  # noqa: E501
        :rtype: datetime
        """
        return self._server_time

    @server_time.setter
    def server_time(self, server_time):
        """Sets the server_time of this ServiceInfo.

        Server time.  # noqa: E501

        :param server_time: The server_time of this ServiceInfo.  # noqa: E501
        :type: datetime
        """

        self._server_time = server_time

    @property
    def versions(self):
        """Gets the versions of this ServiceInfo.  # noqa: E501


        :return: The versions of this ServiceInfo.  # noqa: E501
        :rtype: VersionInfo
        """
        return self._versions

    @versions.setter
    def versions(self, versions):
        """Sets the versions of this ServiceInfo.


        :param versions: The versions of this ServiceInfo.  # noqa: E501
        :type: VersionInfo
        """

        self._versions = versions

    @property
    def error(self):
        """Gets the error of this ServiceInfo.  # noqa: E501

        Error information.  # noqa: E501

        :return: The error of this ServiceInfo.  # noqa: E501
        :rtype: str
        """
        return self._error

    @error.setter
    def error(self, error):
        """Sets the error of this ServiceInfo.

        Error information.  # noqa: E501

        :param error: The error of this ServiceInfo.  # noqa: E501
        :type: str
        """

        self._error = error

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.openapi_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, ServiceInfo):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, ServiceInfo):
            return True

        return self.to_dict() != other.to_dict()
