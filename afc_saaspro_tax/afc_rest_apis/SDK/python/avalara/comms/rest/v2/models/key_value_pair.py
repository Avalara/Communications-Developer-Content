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


class KeyValuePair(object):
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
        'key': 'str',
        'val': 'str'
    }

    attribute_map = {
        'key': 'key',
        'val': 'val'
    }

    def __init__(self, key=None, val=None, local_vars_configuration=None):  # noqa: E501
        """KeyValuePair - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._key = None
        self._val = None
        self.discriminator = None

        self.key = key
        self.val = val

    @property
    def key(self):
        """Gets the key of this KeyValuePair.  # noqa: E501

        Key.  # noqa: E501

        :return: The key of this KeyValuePair.  # noqa: E501
        :rtype: str
        """
        return self._key

    @key.setter
    def key(self, key):
        """Sets the key of this KeyValuePair.

        Key.  # noqa: E501

        :param key: The key of this KeyValuePair.  # noqa: E501
        :type: str
        """

        self._key = key

    @property
    def val(self):
        """Gets the val of this KeyValuePair.  # noqa: E501

        Value.  # noqa: E501

        :return: The val of this KeyValuePair.  # noqa: E501
        :rtype: str
        """
        return self._val

    @val.setter
    def val(self, val):
        """Sets the val of this KeyValuePair.

        Value.  # noqa: E501

        :param val: The val of this KeyValuePair.  # noqa: E501
        :type: str
        """

        self._val = val

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
        if not isinstance(other, KeyValuePair):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, KeyValuePair):
            return True

        return self.to_dict() != other.to_dict()
